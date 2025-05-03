USE TakeawayDB
------------------------------------- CREATE VIEWS ---------------------------------------------
-- View: Order Summary
ALTER VIEW vw_Order_Summary AS
SELECT 
    oh.id AS OrderID,
	s.name StaffName,
    c.name AS CustomerName,
    oh.order_date,
    oh.order_type,
    oh.total_price,
    oh.status,
	p.name PaymentMethod

FROM Order_Header oh
LEFT JOIN Staff s ON oh.staff_id = s.id
LEFT JOIN Customer c ON oh.customer_id = c.id
LEFT JOIN Payment_Method p ON oh.payment_id = p.id;

select * from vw_Order_Summary

-- View: Order Items
CREATE VIEW vw_Order_Items AS
SELECT 
    od.order_id,
    m.name AS MealName,
    od.price,
    od.quantity,
    od.subtotal
FROM Order_Detail od
LEFT JOIN Meal_Details m ON od.meal_id = m.id;
select * from vw_Order_Items

-- View: All Order Details
ALTER VIEW vw_All_Order_Details AS
SELECT 
    oh.id AS OrderID,
    oh.order_date,
	s.name StaffName,
    oh.status,
    oh.order_type,
    oh.total_price,

    c.name AS CustomerName,
    c.phone AS CustomerPhone,

    od.meal_id,
    m.name AS MealName,
    od.price AS MealPrice,
    od.quantity,
    od.subtotal,
	p.name PaymentMethod

FROM Order_Header oh
LEFT JOIN Staff s ON oh.staff_id = s.id
LEFT JOIN Customer c ON oh.customer_id = c.id
LEFT JOIN Order_Detail od ON oh.id = od.order_id
LEFT JOIN Meal_Details m ON od.meal_id = m.id
LEFT JOIN Payment_Method p ON oh.payment_id = p.id;
select * from vw_All_Order_Details

-- View: Meal Details With Category
ALTER VIEW vw_Meal_Details_With_Category AS
SELECT 
    m.id AS MealID,
    m.name AS MealName,
    mc.name AS CategoryName,
    mc.id AS CategoryID,
    m.price,
    m.is_active
FROM Meal_Details m
LEFT JOIN Meal_Category mc ON m.category_id = mc.id;
select * from vw_Meal_Details_With_Category

-- View: Payment Summary
ALTER VIEW vw_Payment_Summary AS
SELECT p.id Payment_id, oh.id Order_id, p.name, p.status, oh.total_price
FROM Payment_Method p
INNER JOIN Order_Header oh ON p.id = oh.payment_id;
select * from vw_Payment_Summary

-- View: Staff List
CREATE VIEW vw_Staff_List AS
SELECT 
    s.id AS StaffID,
    s.name AS StaffName,
    sr.name AS Role,
    s.phone,
    s.is_active
FROM Staff s
LEFT JOIN Staff_Role sr ON s.role_id = sr.id;
select * from vw_Staff_List


