# Task Manager API

A REST API for managing tasks using C# .NET 10 Web API and PostgreSQL.

## Features

- Create tasks
- View all tasks
- View a single task
- Update tasks
- Delete tasks
- Basic input validation
- PostgreSQL database
- Swagger API testing

## Technologies Used

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Npgsql
- Swagger

## Task Fields

Each task contains:

- ID
- Title
- Description
- Status
- Created Date

### Task Status

The available statuses are:

- Pending
- In Progress
- Completed

## API Endpoints

 GET  `/api/Task` - Get all tasks 
 GET  `/api/Task/{id}` - Get a task by ID 
 POST  `/api/Task` - Create a new task |
 PUT  `/api/Task/{id}` - Update a task 
 DELETE  `/api/Task/{id}` - Delete a task 

## Requirements

Before running the project, make sure you have installed:

- .NET 10 SDK
- PostgreSQL

Run the commands
- **dotnet add package Microsoft.EntityFrameworkCore**
- **dotnet add package Microsoft.EntityFrameworkCore.Design**
- **dotnet add package Swashbuckle.AspNetCore**
- **dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL**

Install the EF Core command-line tool
- **dotnet tool install --global dotnet-ef**

Configure PostgreSQL

Generate Migrations

Run the API

Test with Swagger
