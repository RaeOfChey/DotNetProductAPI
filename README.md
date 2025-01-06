## DotNetProductAPI

### Status: In Progress

![License](https://img.shields.io/badge/license-MIT-brightgreen.svg)

## Table of Contents
1. [Description](#description)
2. [Features](#features)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Walkthrough](#walkthrough)
6. [Tools and Technologies](#tools-and-technologies)
7. [Dependencies and Installs](#dependencies-and-installs)
8. [License](#license)
9. [Contributing](#contributing)
10. [Tests](#tests)
11. [Questions](#questions)

## Description
DotNetProductAPI is a simple API built using .NET Core for managing products in an e-commerce system. It allows users to create, read, update, and delete product data. The API interacts with an SQLite database to store product details such as name, description, and price. The project demonstrates how to build and test a basic CRUD API with .NET Core, focusing on best practices and API endpoint design.

## Features
- CRUD Operations: Create, Read, Update, and Delete products.
- SQLite Database: Persistent storage for product data.
- API Endpoints: /api/product for managing product data.
- Swagger UI: Provides a simple interface for testing the API endpoints.
- Testable with Insomnia: Easily test API endpoints with Insomnia or similar tools.
- Product Model: Store product name, description, and price in the database.

## Installation
To use the application, follow these steps:

- Step 1. Clone the repository: git clone https://github.com/yourusername/DotNetProductAPI.git
- Step 2. Navigate to the project directory: cd DotNetProductAPI
- Step 3. Restore the NuGet packages: dotnet restore
- Step 4. Build the project: dotnet build
- Step 5. Run the application: dotnet run

The application will be accessible at http://localhost:5211.

## Usage
- View the API documentation by navigating to http://localhost:5211/swagger in your browser.
- Use Insomnia (or any other API client) to test the following endpoints:
  - GET /api/product: Get a list of all products.
  - POST /api/product: Add a new product.
  - GET /api/product/{id}: Get a specific product by ID.
  - PUT /api/product/{id}: Update a product by ID.
  - DELETE /api/product/{id}: Delete a product by ID.

## Walkthrough
A complete walkthrough video demonstrating the application, its functionality, and the process of invoking it from the command line can be found at the following link: https://drive.google.com/file/d/1Xvd1ffYWVX9Lyf627UhCuv_sEtp4Vu75/view?usp=sharing

**Steps Demonstrated Video Walkthrough**:

Step 1. GET Request
- Endpoint: http://localhost:5211/api/product
- Expected Response:
  - Status: 200 OK
  - Body: [] (empty array)
 
Step 2. POST Request
- Endpoint: http://localhost:5211/api/product
- Body: ` {
    "name": "Sample Product",
    "description": "This is a sample product description.",
    "price": 19.99
} `
- Headers: Content-Type: application/json
- Expected Response:
  - Status: 201 Created
  - Body: `{
    "id": 1,
    "name": "Sample Product",
    "description": "This is a sample product description.",
    "price": 19.99
}`

Step 3. GET Request by ID
- Endpoint: http://localhost:5211/api/product/{id}
- Expected Response:
  - Status: 200 OK
  - Body: `{
    "id": 1,
    "name": "Sample Product",
    "price": 19.99,
    "description": "This is a sample product description."
}`

Step 4. PUT Request by ID
- Endpoint: http://localhost:5211/api/product/{id}
- Body: `{
    "id": 1,
    "name": "Updated Product",
    "price": 29.99,
    "description": "This is an updated product description."
}`
- Expected Response:
  - Status: 204 No Content
  - Body: No body returned

Step 5. GET Request by ID (After Update)
- Endpoint: http://localhost:5211/api/product/{id}
- Expected Response:
  - Status: 200 OK
  - Body: `{
    "id": 1,
    "name": "Updated Product",
    "price": 29.99,
    "description": "This is an updated product description."
}`

Step 6. DELETE Request by ID
- Endpoint: http://localhost:5211/api/product/{id}
- Expected Response:
  - Status: 204 No Content
  - Body: No body returned

Step 7. GET Request (After Deletion)
- Endpoint: http://localhost:5211/api/product
- Expected Response:
  - Status: 200 OK
  - Body: [] (empty array)

## Tools and Technologies
**Frontend Framework**:
- HTML/CSS
- JavaScript

**API Testing**:
- Insomnia
  
**Development Tool**:
- Visual Studio Code
- .NET CLI

**Hosting**:
- Local development environment

## Dependencies and Installs

**Core Dependencies**:
- `Microsoft.EntityFrameworkCore` - Entity Framework Core for data access and SQLite database management.
- `Microsoft.AspNetCore.Mvc` - For building the RESTful API and handling HTTP requests.
- `Swashbuckle.AspNetCore` - For adding OpenAPI (Swagger) documentation support.
- `Microsoft.Extensions.DependencyInjection` - Dependency injection for services and configurations.
- `Microsoft.AspNetCore.OpenApi` - For integrating OpenAPI in the development environment.

**Dev Dependencies**:
- `Microsoft.NET.Sdk.Web` - SDK used for web projects to enable .NET Core features.

## License
This project is licensed under the MIT License, which allows you to freely use, modify, and distribute this software, provided proper attribution is given.

## Contributing
This project is created to demonstrate my proficiency in C# and .NET. As this is a personal project, contributions are not currently accepted. I am not seeking outside assistance or pull requests. Thank you for respecting this decision.

## Tests
Currently, this project does not have any automated tests.

## Questions
If you have any questions about the repository, feel free to reach out by opening an issue or contacting me directly at cheyennaraelynn@gmail.com You can also find more of my work on GitHub at https://github.com/RaeOfChey.
