# Simple Computer Shop API
ASP.NET CORE API Project

## Project Setup

### Prerequisites
Ensure you have the following installed:

```text
Visual Studio 2017 or later
Postgresql
```

### App Settings

Update the database connection string in `appsettings.json` with a valid user id and password

```json
"ConnectionStrings": {
    "ComputerShopConnection": "Server=127.0.0.1;port=5432;user id = <DB USER>;password = <DB PASSWORD>; database=SimpleComputerShopDatabase;"
  }
```

### Run Database Migrations
After update the connection string in appsettings above, run the following command in package manager console to run migrations

``` bash
> Update-Database
```

### Run API Tests
In visual studio open the `Test Explorer` window and run or debug the tests from the menu options.

Or

Navigate to `APITests` from the command line and run `dotnet test` to run the unit tests.

### Run App
In visual studio select any option from either `Project`, `IISExpress` or `Docker` to start project.

The application launches on `http://localhost:5000/`.

Find the postman collection in the `Resources` folder.
