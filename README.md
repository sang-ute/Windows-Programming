---
# 🎓 Windows Programming Checkpoint Project - HCMUTE

This project is developed in **C# using ADO.NET**, created as a **course checkpoint** for the **Windows Programming** subject at **Ho Chi Minh City University of Technology and Education (HCMUTE)**.

The application focuses on role-based interaction within an educational environment and showcases key features of Windows Forms development, including database connectivity, file handling, and UI controls such as `DataGridView`.

---

## ✨ Features

### 🔐 Role-Based Access Control
- **Student**:
  - View personal information.
  - View enrolled subjects and corresponding marks.

- **Teacher**:
  - Upload subject or student data via CSV files.
  - Manage subjects and faculties assigned to them.
  - View and update student marks for their subjects.

- **Admin**:
  - Full **CRUD** privileges on all data.
  - Manage all users, faculties, and subjects.
  - Assign teachers to subjects and manage system-wide configurations.

---

### 📄 File Upload Support
- Upload **CSV files** to bulk import:
  - Subjects
  - Students
  - Marks
- Proper parsing and error checking during upload.

---

### 🛠 Dynamic Data Management
- Add, edit, or remove:
  - Subjects
  - Faculties
- Assign and manage subjects per faculty.
- Teachers and Admins can modify data based on their roles.

---

### 🖥 User Interface Features
- **DataGridView** used for displaying and interacting with data.
- Supports:
  - Dynamic columns
  - Sorting and filtering
  - Inline editing (where permitted)
  - Search and refresh capabilities

---

## 🧰 Technologies Used

- **C# (Windows Forms)**
- **ADO.NET** for database interaction
- **Visual Studio** (`.sln` solution file provided)
- **CSV File Parsing**
- **Role-Based UI Control**

---

## ⚙️ Setup Instructions

> ⚠️ Before running the application, you need to configure your database and update the connection string in the code.

1. Clone this repository:

   git clone [ https://github.com/your-username/your-repo.git](https://github.com/sang-ute/Windows-Programming/)

2. Open the `.sln` file using **Visual Studio**.

3. Configure your database and update the **connection string** accordingly:
   string connectionString = "your-connection-string-here";

4. Build and run the project.

---

## 📌 Project Purpose

This application serves as a checkpoint assignment, demonstrating knowledge in:
- Windows Forms GUI
- ADO.NET and database communication
- File handling (CSV)
- Role-based access logic
- Data visualization using GridView

---

## 📬 Contact

For any questions, issues, or feature requests, feel free to create an issue or reach out via the repository page.

---
