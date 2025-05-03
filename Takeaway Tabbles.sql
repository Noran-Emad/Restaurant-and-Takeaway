CREATE DATABASE TakeawayDB;
USE TakeawayDB
------------------------------------- CREATE TABLES ---------------------------------------------
-- Meal_Category
CREATE TABLE Meal_Category (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50) NOT NULL UNIQUE,
    description VARCHAR(50)
);

-- Meal Details
CREATE TABLE Meal_Details (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10,2) NOT NULL,
    category_id INT NOT NULL,
	is_active BIT DEFAULT 1,
    FOREIGN KEY (category_id) REFERENCES Meal_Category(id) ON DELETE CASCADE
);
ALTER TABLE Meal_Details
ADD 
    stock INT DEFAULT 0,
    warning_level INT DEFAULT 3;

-- Customer
CREATE TABLE Customer (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(20) NOT NULL UNIQUE,
    street VARCHAR(100),
    city VARCHAR(50),
);

-- Staff_Role
CREATE TABLE Staff_Role (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50) NOT NULL UNIQUE,
    description VARCHAR(50),
);

-- Staff
CREATE TABLE Staff (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(20) NOT NULL,
    address VARCHAR(200),
    role_id INT NOT NULL,
    is_active BIT DEFAULT 1,
    FOREIGN KEY (role_id) REFERENCES Staff_Role(id) ON DELETE No Action
);

-- Payment_Method
CREATE TABLE Payment_Method (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50) NOT NULL UNIQUE,
	status VARCHAR(20) DEFAULT 'pending' 
        CONSTRAINT chk_payment_status CHECK (status IN ('pending', 'completed', 'failed')),
);

-- Order_Header
CREATE TABLE Order_Header (
    id INT PRIMARY KEY IDENTITY(1,1),
    order_date DATE DEFAULT CAST (GETDATE() AS DATE),
    total_price DECIMAL(10,2) NOT NULL,
    customer_id INT Default 0,
    status VARCHAR(20) DEFAULT 'pending' 
		CONSTRAINT chk_status CHECK (status IN ('pending', 'processing', 'completed', 'canceled')),
    order_type VARCHAR(20) DEFAULT 'pickup' 
        CONSTRAINT chk_order_type CHECK (order_type IN ('delivery', 'pickup')),
    notes TEXT,
	payment_id INT Default 0,
	staff_id INT Default 0,
    FOREIGN KEY (customer_id) REFERENCES Customer(id) ON DELETE SET Default,
    FOREIGN KEY (payment_id) REFERENCES Payment_Method(id) ON DELETE SET Default,
    FOREIGN KEY (staff_id) REFERENCES Staff(id) ON DELETE SET Default
);
-- Order_Detail
CREATE TABLE Order_Detail (
    id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT NOT NULL,
    meal_id INT NOT NULL default 0,
    price DECIMAL(10,2) NOT NULL,
    quantity INT NOT NULL,
    subtotal AS (price * quantity) PERSISTED,
    FOREIGN KEY (order_id) REFERENCES Order_Header(id) ON DELETE CASCADE,
    FOREIGN KEY (meal_id) REFERENCES Meal_DETAILS(id) ON DELETE SET DEFAULT
);

-- Index
CREATE INDEX idx_meal_id ON Order_Detail(meal_id);