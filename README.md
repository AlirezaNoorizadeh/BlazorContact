
# Mini CRUD Project with Database Integration

This project demonstrates how to integrate a database and perform CRUD (Create, Read, Update, Delete) operations in a minimal and straightforward way using Blazor and Entity Framework Core.

---

## 🚀 How to Run the Project

Follow these steps to set up and run the project on your local machine:

### 1. Clone the Repository
First, clone the repository to your local machine using the following command:
```bash
git clone https://github.com/AlirezaNoorizadeh/BlazorContact.git
```

### 2. Set Up the Database Connection
- Open the file `BlazorContact/Shared/Data/ContactDbContext.cs`.
- Replace the placeholder `"ConnectionString"` inside `optionsBuilder.UseSqlServer("ConnectionString")` with your actual database connection string.
- Optionally, customize the table name by modifying the `Catalog` parameter in the connection string.

Example of a connection string:
```plaintext
Server=your_server_name;Database=your_database_name;Trusted_Connection=True;
```

### 3. Run Database Migrations
- Open the **Package Manager Console** in Visual Studio by navigating to `Tools > NuGet Package Manager > Package Manager Console`.
- Run the following commands to create and update the database schema:
  ```bash
  Add-Migration YourMigrationName
  Update-Database
  ```

### 4. Build and Run the Project
- Build the project in Visual Studio.
- Run the project to see the mini CRUD application in action.

---

## 🎯 Project Goal
The goal of this project is to demonstrate how to:
- Integrate a database into a Blazor application.
- Perform basic CRUD operations (Create, Read, Update, Delete) in a simple and minimal way.

---

## 📂 Project Structure
Here’s an overview of the project structure:

| Folder/File               | Description                                  |
|---------------------------|----------------------------------------------|
| **📦 BlazorContact.Client**  | Contains the client-side Blazor components.  |
| - `Pages/`                | UI components (e.g., `AddContact.razor`, `ContactList.razor`). |
| - `Shared/`               | Shared components (e.g., `MainLayout.razor`, `NavMenu.razor`). |
| - `Program.cs`            | Entry point for the client application.      |
|                           |                                              |
| **🖧 BlazorContact.Server**  | Contains the server-side logic and APIs.     |
| - `Controllers/`          | API controllers (e.g., `ContactController.cs`). |
| - `appsettings.json`      | Configuration file for server settings.      |
| - `Program.cs`            | Entry point for the server application.      |
|                           |                                              |
| **💾 BlazorContact.Shared**  | Shared resources and database logic.         |
| - `Data/`                 | Database context (`ContactDbContext.cs`).    |
| - `Migrations/`           | Entity Framework Core migration files.       |
| - `Models/`               | Data models (e.g., `Contact.cs`).            |
---

## 🛠️ Tools and Technologies Used
- **Blazor** for the front-end framework.
- **Entity Framework Core** for database operations.
- **SQL Server** as the database.
- **Visual Studio** as the development environment.

---

## 📜 License [ [![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE) ]
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🙏 Acknowledgments
- Thanks to the Blazor and Entity Framework Core communities for their excellent documentation and support.
