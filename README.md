# TestWebApi

This is a simple Web API built using ASP.NET Core. It provides basic functionality to manage a `Person` model in a SQL Server database. The application utilizes data annotations for value validation in the `Person` model.

## Prerequisites

Before running the application, make sure you have the following installed:

- **.NET 8.0 SDK** (or newer)
- **SQL Server** (local or remote instance)

## Setup Instructions

Follow these steps to run the application:

### 1. Clone the Repository

Clone this repository to your local machine:

```bash
git clone <repository_url>
cd TestWebApi
```

### 2. Update the Connection String

The application uses a SQL Server database. To configure the database connection:

1. Open the `appsettings.json` file in the project root directory.
2. Update the `DefaultConnection` value in the connection strings section to match your SQL Server instance. For example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_user_id;Password=your_password;"
  }
}
```

Replace `your_server_name`, `your_database_name`, `your_user_id`, and `your_password` with your actual SQL Server details.

### 3. Update the Database

Once the connection string is updated, you need to apply the migrations to the database.

#### Update the Database

Apply the migration to the database:

```bash
dotnet ef database update
```

This will create the necessary tables in your SQL Server database.

### 4. Run the Application

To start the application, run the following command:

```bash
dotnet run
```

The application will be available at `https://localhost:5001` by default.


### 5. Value Validation with Data Annotations

The `Person` model uses **data annotations** to enforce value validation. Below are the data validation rules implemented in the `Person` model:

- **Name**: Cannot be empty or null (required field).
- **Age**: Must be a positive integer (valid age).
- **Town**: Cannot be empty or null (required field).

If any data does not meet these validation requirements when submitting a request, the API will return a `400 Bad Request` response with details about the validation errors.


### Key Additions:

- **Value Validation with Data Annotations**: This section informs the user that data annotations are used to enforce validation rules such as required fields and positive integer validation.