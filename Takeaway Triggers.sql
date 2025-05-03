USE TakeawayDB;

CREATE TRIGGER trg_DeductStockOnOrder
ON Order_Detail
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Meal_Details m ON i.meal_id = m.id
        WHERE m.stock < i.quantity
    )
    BEGIN
        RAISERROR('Not enough stock for one or more meals.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Deduct stock
    UPDATE m
    SET m.stock = m.stock - i.quantity
    FROM Meal_Details m
    JOIN inserted i ON i.meal_id = m.id;
END;

CREATE TRIGGER trg_CheckMealActive
ON Order_Detail
AFTER INSERT
AS
BEGIN
    DECLARE @meal_id INT;
    SELECT @meal_id = meal_id FROM inserted;

    -- If the meal is inactive, prevent insertion (raise error)
    IF EXISTS (SELECT 1 FROM Meal_Details WHERE id = @meal_id AND is_active = 0)
    BEGIN
        RAISERROR('The selected meal is no longer available.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

ALTER TRIGGER trg_DeactivateMealOnZeroStock
ON Meal_Details
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE m
    SET is_active = 0
    FROM Meal_Details m
    JOIN inserted i ON m.id = i.id
    WHERE i.stock <= 0 AND m.is_active = 1;
END;

ALTER TRIGGER trg_UpdateTotalPrice
ON Order_Detail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @order_id INT;

    -- Handle the inserted or deleted rows
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        SELECT @order_id = order_id FROM inserted;
    END
    ELSE IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        SELECT @order_id = order_id FROM deleted;
    END

    -- Recalculate the total price for the order
    UPDATE oh
    SET oh.total_price = (
        SELECT SUM(od.subtotal)
        FROM Order_Detail od
        WHERE od.order_id = @order_id
    )
    FROM Order_Header oh
    WHERE oh.id = @order_id;
END;

CREATE TRIGGER trg_UpdateOrderStatusAfterPayment
ON Order_Header
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Update orders where the linked payment method is marked completed
    UPDATE oh
    SET oh.status = 'completed'
    FROM Order_Header oh
    INNER JOIN inserted i ON oh.id = i.id
    INNER JOIN Payment_Method pm ON oh.payment_id = pm.id
    WHERE pm.status = 'completed';
END;

