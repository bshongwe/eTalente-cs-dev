# eTalente-cs-dev
eTalente Interview Assessment

# Banking Microservice

This is a microservice application that exposes a secure REST API for managing bank accounts. It is built using .NET Core Web API and Entity Framework for data access.

## Features

- Retrieve a list of bank accounts for a given account holder.
- Retrieve a single bank account for a given account number.
- Create a new withdrawal for a given bank account.
- Implement JWT for API authentication and authorization.
- Store an audit trail for bank account data with timestamps for modifications.
- Unit tests for all components.

## Getting Started

1. Clone the repository:

    ```bash
    git clone https://github.com/bshongwe/eTalente-cs-dev.git 
    ```

2. Navigate to the project directory:

    ```bash
    cd eTalente-cs-dev
    ```

3. Build the project:

    ```bash
    dotnet build
    ```

4. Run the project:

    ```bash
    dotnet run
    ```

5. Access the API documentation using Swagger by navigating to:

    ```
    https://localhost:3000/swagger
    ```

## Running Tests

To run the unit tests:

```bash
dotnet test
```

## Technologies Used

- .NET Core 5
- Entity Framework Core
- xUnit
- Swagger


# Development Roadmap (my notes)
-   <code>dotnet new webapi -n eTalente-cs-dev</code>
-   <code>cd eTalente-cs-dev</code>
-   for tests:
    -   <code>dotnet add package Microsoft.AspNetCore.Mvc.Testing --version 5.0.10</code>
    -   <code>dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.10</code>
    -   <code>dotnet new xunit -n BankingMicroservice.Tests</code>


