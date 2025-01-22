# ToDo RestAPI Project

## Overview

This is a ToDo API project built using ASP.NET Core and Entity Framework Core. The API provides basic CRUD (Create, Read, Update, Delete) functionality for managing ToDo tasks. The project follows the principles of MVC architecture and SOLID design patterns.

## Features

### 1.CRUD operations for ToDo items:

- Create new tasks

- Retrieve all tasks or a specific task by ID

- Update existing tasks

- Delete tasks

### 2.SQL Server Integration for database management

### 3.Dependency Injection (DI) for scalable architecture

### 4.Organized code structure with:

- Controllers

- Services

- Models

- Infrastructure (Database Context)

## Technologies Used

- ASP.NET Core 6.0 or later

- Entity Framework Core

- SQL Server

- Postman for API testing

- Git for version control

- JetBrains Rider (or any IDE)

## Installation

### Prerequisites

- .NET 6.0 SDK

- SQL Server (LocalDB or full installation)

- Postman (optional, for API testing)

### Steps

#### 1.Clone the repository:
```bash
git clone https://github.com/CengizhanKARAGOZ/ToDoRestAPI.git
cd ToDoRestAPI
```

#### 2.Restore NuGet packages:
```bash
dotnet restore
```
#### 3.Update the database connection string in appsettings.json:
```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=ToDoDb;Integrated Security=True;"
  }
}
```

#### 4.Apply database migrations:
```bash
dotnet ef database update
```

#### 5.Run the project:
```bash
dotnet run
```

#### 6.Open Postman or your browser to test the API:
##### Get all task
```http
GET http://localhost:5000/api/todo
```

##### Post a new task
```http
POST http://localhost:5000/api/todo
```

## API Endpoints

### Base URL
```http
http://localhost:5000/api/todo
```
## Methods
| Method | Endpoint     | Description                |
| :-------- | :------- | :------------------------- |
| `GET` | `/` | Get all tasks |
| `GET` | `/{id}` | Get a task by ID |
| `POST` | `/` | Create a new task |
| `PUT` | `/{id}` | Update an existing task |
| `DELETE` | `/{id}` | Delete a task |

## Example JSON for POST/PUT
```http
{
  "title": "Learn ASP.NET Core",
  "isCompleted": false
}
```

## Project Structure
```
.
├── Controllers/
│   └── ToDoController.cs
├── Models/
│   └── ToDoItem.cs
├── Data/
│   └── ToDoContext.cs
├── Services/
│   ├── IToDoService.cs
│   └── ToDoService.cs
├── Infrastructure/
│   └── Startup.cs
├── appsettings.json
└── Program.cs
```
## Contribution

Contributions are welcome! Feel free to fork the repository and submit a pull request.



