**Note:** This project is still a work in progress.
 I am currently developing a connected desktop application that integrates with this database system.


# Restaurant & Takeaway Database

A complete SQL-based relational database designed to manage a restaurant and takeaway system.  
The project includes database schema, sample data, and SQL triggers for automating business logic.
Also includes a Windows desktop POS application, built with .NET, that integrates with this database for real-time operations.

---

## Project Structure

## Solution Overview
 It connects directly to the restaurant database to manage:
- Menu and order entry
- Billing and payments
- POS terminal interface for staff

- **Takeaway Tables.sql**  
  Contains the table definitions for the database, including:
  - Customers
  - Orders
  - Menu Items
  - Categories
  - Delivery Staff
  - Payments
  - Branches

- **Takeaway Veiw.sql**  
Contains SQL views that simplify querying common data (e.g., order summaries, customer activity).

- **Takeaway Inserts.sql**  
  Sample data to populate the database tables for testing and demonstration.

- **Takeaway Triggers.sql**  
  SQL triggers to handle automatic updates and data consistency:
  - Example: Auto-update order status or update stock on insert.

---

## Technologies Used
- SQL Server (T-SQL)
- Relational Database Design
- Triggers and Constraints
---
