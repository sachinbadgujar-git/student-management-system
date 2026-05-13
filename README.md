
# Student Management System





# Project Structure

```txt
Assessment
│
├── Backend
│     └── StudentManagementSystem
│
└── Frontend
      └── student-management-ui
```

---

# Backend Setup Steps

## Step 1 — Open Backend Folder

```bash
cd Backend/StudentManagementSystem
```

---

## Step 2 — Restore Packages

```bash
dotnet restore
```

---

## Step 3 — Run Database Migration

```bash
dotnet ef database update
```

---

## Step 4 — Run Backend API

```bash
dotnet run
```

Backend URL:

```txt
http://localhost:5296
```

Swagger URL:

```txt
http://localhost:5296/swagger
```

---

# Frontend Setup Steps

## Step 1 — Open Frontend Folder

```bash
cd Frontend/student-management-ui
```

---

## Step 2 — Install Packages

```bash
npm install
```

---

## Step 3 — Run React Application

```bash
npm start
```

Frontend URL:

```txt
http://localhost:3000
```

---

# Login Credentials

```txt
Username: admin
Password: admin123



```
<img width="1562" height="733" alt="image" src="https://github.com/user-attachments/assets/72a8f5bc-399f-4694-9af6-bbf5d33377fb" />
<img width="1363" height="636" alt="image" src="https://github.com/user-attachments/assets/31c21d58-e43b-47a8-914b-dc61d66feac2" />
<img width="1912" height="1027" alt="image" src="https://github.com/user-attachments/assets/e1e6fa42-1189-45c7-a15a-b17889558696" />



---

# Database Configuration

Update `appsettings.json` connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

# API Endpoints

## Authentication

```txt
POST /api/auth/login
```

## Student APIs

```txt
GET    /api/student
POST   /api/student
PUT    /api/student/{id}
DELETE /api/student/{id}
```

---



---

# GitHub Repository



```txt
https://github.com/sachinbadgujar-git/student-management-system.git
```

---

````
