USE TakeawayDB;

-- Insert into Meal_Category
INSERT INTO Meal_Category (name, description)
VALUES 
('Main Course', 'Hearty dishes'),
('Soups', 'All types of soups'),
('Pizza', 'All types of Italian pizza'),
('Appetizers', 'Starters and small bites'),
('Drinks', 'Soft or hot drinks'),
('Desserts', 'Sweet dishes');

-- Insert into Meal_Details
INSERT INTO Meal_Details (name, description, price, category_id, stock, warning_level, is_active)
VALUES 
('Chicken Biryani', 'Spiced rice with chicken', 80.99, 1, 10, 3, 1),
('Beef Burger', 'Juicy grilled beef patty in a bun', 89.00, 1, 10, 2, 1),
('Grilled Chicken Sandwich', 'Grilled chicken with lettuce and mayo', 75.50, 1, 15, 3, 1),
('Paneer Butter Masala', 'Indian cottage cheese in creamy tomato gravy', 79.00, 1, 12, 3, 1),
-- Pizaa
('Veggie Pizza', 'Pizza topped with capsicum, onions, and olives', 85, 3, 10, 2, 1),
('Pepperoni Pizza', 'Pizza topped with pepperoni and cheese', 99, 3, 6, 2, 1),
('BBQ Chicken Pizza', 'Pizza with barbecue chicken topping', 105, 3, 8, 3, 1),
('Cheese Burst Pizza', 'Pizza with extra cheese filling', 90, 3, 9, 3, 1),
-- Soups
('Chicken Soup', 'Spiced chicken soup', 49, 2, 12, 5, 1),
('Vegetable Soup', 'Mixed veggie soup with herbs', 40, 2, 15, 5, 1),
('Tomato Soup', 'Creamy tomato-based soup', 42, 2, 20, 4, 1),
('Hot and Sour Soup', 'Spicy and tangy soup with vegetables or chicken', 50, 2, 10, 3, 1),
-- Appetizers
('Spring Rolls', 'Crispy vegetable rolls', 45, 4, 20, 3, 1),
('French Fries', 'Golden fried potato sticks', 40.00, 4, 25, 5, 1),
('Garlic Bread', 'Toasted bread with garlic and herbs', 30.00, 4, 18, 3, 1),
-- Drinks
('Mango Lassi', 'Sweet yogurt drink', 35, 5, 15, 1, 1),
('Cold Coffee', 'Chilled coffee with cream and ice', 50.00, 5, 20, 3, 1),
('Lemon Soda', 'Refreshing soda with lemon and salt', 25.00, 5, 30, 5, 1),
('Masala Chai', 'Spiced Indian tea', 20.00, 5, 40, 10, 1),
-- Desserts
('Gulab Jamun', 'Milk-based dessert', 60, 6, 8, 3, 1),
('Chocolate Cake Slice', 'Moist chocolate cake slice with icing', 70.00, 6, 10, 2, 1),
('Ice Cream Sundae', 'Vanilla ice cream with chocolate syrup and nuts', 65.00, 6, 15, 3, 1),
('Rasmalai', 'Soft cheese balls in sweetened milk', 55.00, 6, 8, 2, 1);

INSERT INTO Locations (name, description, delivery_fee)
VALUES 
    ('Downtown', 'City center hub', 30),
    ('Suburbia', 'Quiet residential area', 25),
    ('Industrial Park', 'Near factories', 20),
    ('Uptown', 'Trendy shopping district', 35),
    ('Riverside', 'Scenic river views', 40);

-- Insert into Customer
INSERT INTO Customer (name, phone, street, location_id)
VALUES 
('Ahmed Emad', '01012345777', '15 Al-Nasr St', 1),
('Ahmed Mostafa', '01012345678', '15 Al-Nasr St', 2),
('Fatma Hassan', '01098765432', '22 October Rd', 3),
('Hoor Mostafa', '01010345678', '15 Al-Asr St', 5),
('Dana Hassan', '01098553332', 'total Rd', 5);

-- Insert into Staff_Role
INSERT INTO Staff_Role (name, description)
VALUES 
('Manager', 'Manages the branch'),
('Chef', 'Prepares food'),
('Delivery', 'Delivers orders'),
('Cashier', 'Manage Cash');

-- Insert into Staff
INSERT INTO Staff (name, phone, address, role_id, is_active)
VALUES 
('Mohamed Hossam', '01112345678', '12 Tahrir Sq', 1, 1), -- Manager
('Emad Hossam', '01112345678', '12 Tahrir Sq', 1, 1), -- Manager
('Noran Ehab', '01298765432', '45 Maadi St', 2, 1),     -- Chef
('Salma Ehab', '01298765432', '45 Maadi St', 2, 1),     -- Chef
('Omar Khaled', '01055551234', '78 Heliopolis Rd', 3, 1), -- Delivery
('Ahmed Khaled', '01055551234', '78 Heliopolis Rd', 3, 1), -- Delivery
('Omar Khaled', '01055551234', '78 Heliopolis Rd', 4, 1), -- Cashier
('Ahmed Khaled', '01055551234', '78 Heliopolis Rd', 4, 1); -- Cashier


-- Insert into Payment_Method
INSERT INTO Payment_Method (name)
VALUES 
('Cash'),
('Credit Card'),
('Mobile Payment');

-- Insert into Order_Header
INSERT INTO Order_Header (
    order_date, total_price, customer_id, status, order_type, notes, payment_id, staff_id)
VALUES 
(GETDATE(), 220.99, 1, 'pending', 'pickup', 'No onions please', 1, 1), -- Cash
(GETDATE(), 150.00, 2, 'pending', 'delivery', 'Extra spicy', 2, 2),   -- Credit Card
(GETDATE(), 180.50, 1, 'processing', 'pickup', 'Add napkins', 3, 3),  -- Mobile Payment
(GETDATE(), 95.00, 2, 'completed', 'delivery', 'Contactless delivery', 2, 1), -- Credit Card
(GETDATE(), 0, 1, 'completed', 'pickup', 'No sugar in drink',2, 2),  -- Credit Card
(GETDATE(), 0, 2, 'canceled', 'delivery', 'Changed mind',1, 1);  -- Cash

-- Insert into Order_Detail
INSERT INTO Order_Detail (order_id, meal_id, price, quantity)
VALUES 
(1, 1, 80.99, 2),  -- Chicken Biryani x2
(1, 2, 45, 1),  -- Spring Rolls x1
(2, 3, 70, 2),  -- Mango Lassi x2
(3, 5, 85, 1),  -- Veggie Pizza
(3, 8, 40, 2),  -- French Fries
(4, 6, 25, 3),  -- Lemon Soda x3
(5, 4, 45, 2),  -- Chicken Soup x2
(6, 1, 80.99, 1); -- Chicken Biryani x1  #Canceled Order
