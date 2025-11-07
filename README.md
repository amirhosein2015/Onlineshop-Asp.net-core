# 🛍️ Online Shop - ASP.NET Core Project

## 🌐 Project Overview
This project is a **complete e-commerce web application** developed using **ASP.NET Core** and **C#**.  
It demonstrates how to design and implement a **scalable, secure, and modular online store backend** using modern **.NET technologies** and **clean architectural principles**.

🎥 **Demo Video:** [Watch on YouTube](https://youtu.be/wEs8a78umnk)  
💻 **Source Code:** [View on GitHub](https://github.com/amirhosein2015/Onlineshop-Asp.net-core)

---

## 🧩 Main Features
- 🛒 Full shopping experience: Product browsing, cart management, and checkout  
- 🧑‍💼 Admin dashboard for managing products, categories, and orders  
- 🔐 Secure authentication and role-based authorization  
- 🧾 Order tracking system with order status management  
- 🖼️ Image upload support for product management  
- 📊 Dashboard with sales and product statistics  
- 💬 Customer contact and feedback module  
- 🧰 Error handling and validation system  

---

## ⚙️ Backend Architecture & Highlights

### 🧠 **Clean Architecture Design**
The backend follows **Clean Architecture principles**, separating:
- **Controllers** for request handling  
- **Services / Business Layer** for business logic  
- **Repositories / Data Access Layer** for database communication  
- **Models & DTOs** for structured data exchange  

This ensures:
✅ **High maintainability**  
✅ **Testability**  
✅ **Separation of concerns (SoC)**  
✅ **Scalability for future features**

---

### 🔄 **Entity Framework Core Integration**
- Code-first migrations for easy database management  
- LINQ-based queries for optimized data access  
- Efficient use of **DbContext**, **Repositories**, and **Unit of Work** pattern  
- Support for **lazy loading** and **eager loading** relationships  

---

### 🔐 **Authentication & Authorization**
- Implemented with **ASP.NET Core Identity**  
- Supports **Role-based access** (Admin, User)  
- Secure password hashing and token-based session management  
- Authorization middleware to restrict admin-only routes  

---

### 📦 **Product & Order Management**
- Full CRUD operations for products and categories  
- Price management, product images, and inventory quantity tracking  
- Order lifecycle management: *Created → Processing → Completed*  
- Real-time updates in admin dashboard  

---

### 📈 **Performance & Reliability**
- Repository pattern for clean data access  
- Efficient **asynchronous operations (async/await)**  
- Built-in **dependency injection** for modular design  
- Configurable **logging and error handling** middleware  
- Strong **input validation** using Fluent Validation and model binding  

---

### 🧰 **Database & Infrastructure**
| Layer | Technology |
|--------|-------------|
| ORM | Entity Framework Core |
| Database | SQL Server |
| Architecture | MVC + Service Layer + Repository Pattern |
| Hosting | Ready for IIS / Azure Deployment |
| Migrations | EF Core Migrations |
| Dependency Management | Built-in DI container |

---

## 💡 Purpose & Motivation
The goal of this project was to simulate a **real-world online shopping platform** and focus deeply on **backend architecture**, **data modeling**, and **secure user management**.  
This project allowed me to practice building enterprise-grade solutions with **clean and modular backend design**, preparing for large-scale .NET applications.

---

## 🧰 Technologies Used
| Category | Technology |
|-----------|-------------|
| Backend | ASP.NET Core, C# |
| Frontend | HTML, CSS, Bootstrap |
| Database | SQL Server, Entity Framework Core |
| Authentication | ASP.NET Identity |
| Architecture | MVC + Clean Architecture |
| Tools | Visual Studio, Git, LINQ |

---

## 🚀 How to Run
1. Clone the repository  
   ```bash
   git clone https://github.com/amirhosein2015/Onlineshop-Asp.net-core.git
   ```

2.Open the solution in Visual Studio

3.Update the connection string in appsettings.json

4.Run migrations:
   ```bash
dotnet ef database update
   ```

Start the project and explore the online shop 🎉

## 🔮 Future Improvements

🧾 Integrate an online payment gateway (e.g., Stripe, PayPal)

📱 Add RESTful API for mobile app integration

🛍️ Improve caching and performance with Redis

💬 Add product reviews and rating system

🧮 Implement sales reports and analytics

## 👨‍💻 About the Developer

👋 Abdollah Mohajeri — Passionate .NET Developer with strong interest in backend architecture, clean code, and scalable web systems.
This project reflects my dedication to mastering ASP.NET Core and creating production-ready applications.

🔗 GitHub: amirhosein2015

💼 LinkedIn: View My Profile

⭐ If you like this project, don’t forget to star the repository and share your feedback!
