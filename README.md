# RestCalc

RestCalc is a RESTful API developed in .NET 8 to perform basic mathematical operations. Designed to be lightweight, scalable and easy to integrate, this calculator exposes endpoints to add, subtract, multiply, divide and perform other mathematical operations. Ideal for applications that require precise calculations via API.

## Features

- Basic arithmetic operations (addition, subtraction, multiplication, division)
- Clear API documentation with Swagger
- JSON response format
- Error handling for invalid operations (like division by zero)

## Technologies

- .NET 8
- ASP.NET Core Web API
- Swagger for API documentation

## Prerequisites

- .NET 8 SDK
- Git

## Installation

Clone the repository:

```bash
git clone git@github.com:MateusjsSilva/RestCalc.git
cd RestCalc
```

Build and run the project:

```bash
cd RestCalc.Api
dotnet build
dotnet run
```

The API will be available at `https://localhost:7xxx` and `http://localhost:5xxx` (the exact ports will be shown in the console output).

## Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the Apache License.
