# Peak API

A Peak API is an ASP.NET Core Web API that provides endpoints for calculating installments and get persons.

## Environment Setup

- .NET 8;
- Visual Studio.

## Installation

1. Clone the repository;
2. Navigate to the project directory;
3. Run the application.

The application will be available at `http://localhost:44322`.

## Endpoints

### Calculate Installments

#### Request
POST /calculate?installments={installments}&value={value}

Parameters:
- `installments` (required): Number of desired installments.
- `value` (required): Total value of the purchase.

#### Response
- `200 OK` if the request is successful. Returns the calculated installment value.
- `400 Bad Request` if there is an error in the request. Returns the error message.

#### Request
GET /person/{id}

Parameters:
- `id` (required): ID of the person to be queried.

#### Response
- `200 OK` if the request is successful. Returns the information about the queried person.
- `404 Not Found` if the person is not found. Returns the error message.
