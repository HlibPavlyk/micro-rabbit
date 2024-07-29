# MicroRabbit Application

## Overview

The **MicroRabbit** application is a microservices-based architecture built using ASP.NET Core. It consists of multiple microservices that handle different domains of the application. The primary focus of this application is to demonstrate the implementation of microservices with a focus on using RabbitMQ for message brokering. RabbitMQ facilitates communication between the microservices, ensuring reliable and scalable message exchange. This setup showcases how RabbitMQ can be integrated into a microservices architecture to achieve efficient and decoupled service interactions.

## Microservices

### Banking Service
- **Namespace**: `MicroRabbit.Banking`
- **Description**: Handles banking-related operations such as account management.
- **Key Components**:
    - `IAccountRepository`: Interface for account repository.
    - `AccountRepository`: Implementation of the account repository.
    - `BankingDbContext`: Entity Framework Core context for banking operations.

### Transfer Service
- **Namespace**: `MicroRabbit.Transfer`
- **Description**: Manages transfer operations between accounts.
- **Key Components**:
    - `ITransferRepository`: Interface for transfer repository.
    - `TransferRepository`: Implementation of the transfer repository.
    - `TransferDbContext`: Entity Framework Core context for transfer operations.

## Common Components

### Infrastructure
- **Namespace**: `MicroRabbit.Infrastructure`
- **Description**: Contains common infrastructure code such as dependency injection and messaging.
- **Key Components**:
    - `DependencyContainer`: Registers services and dependencies.
    - `RabbitMqBus`: Implementation of the event bus using RabbitMQ.

## RabbitMQ Integration

RabbitMQ is used as the messaging backbone for the microservices. It enables asynchronous communication between the services, ensuring loose coupling and scalability.

### Key Components
- **Event Bus**: The `RabbitMqBus` class implements the event bus using RabbitMQ.
- **Event Handlers**: Each microservice can publish and subscribe to events through RabbitMQ.

### Configuration
- **Connection Settings**: RabbitMQ connection settings are configured in the `appsettings.json` file.
- **Dependency Injection**: The `DependencyContainer` class registers the RabbitMQ bus and event handlers.

## MVC Application

### Namespace
- `MicroRabbit.Mvc`

### Description
ASP.NET Core MVC application that serves as the front-end for the microservices.

### Key Components
- `TransferViewModel`: ViewModel for transfer operations.
- `HomeController`: Handles HTTP requests for the home page and transfer operations.
- `TransferService`: Service for handling transfer operations.

## Getting Started

### Prerequisites
- .NET 6.0 SDK
- SQL Server
- RabbitMQ

### Running the Application

1. **Clone the repository**:
    ```sh
    git clone https://github.com/HlibPavlyk/micro-rabbit.git
    cd micro-rabbit
    ```

2. **Set up the databases**:
    - Update the connection strings in `appsettings.json` for both `BankingDbContext` and `TransferDbContext`.

3. **Run RabbitMQ**:
    - Ensure RabbitMQ is installed and running on your machine or server.

4. **Run the microservices**:
    - Navigate to the `src/MicroRabbit.Banking.Api` directory and run:
      ```sh
      dotnet run --urls "https://localhost:7087"
      ```
    - Navigate to the `src/MicroRabbit.Transfer.Api` directory and run:
      ```sh
      dotnet run --urls "https://localhost:7289"
      ```

5. **Run the MVC application**:
    - Navigate to the `src/MicroRabbit.Mvc` directory and run:
      ```sh
      dotnet run --urls "https://localhost:7171"
      ```

### Usage

- Access the Banking Service at `https://localhost:7087`.
- Access the Transfer Service at `https://localhost:7289`.
- Access the MVC application at `https://localhost:7171`.
- Use the provided forms to perform banking and transfer operations.


## Contributing

Contributions are welcome! Please submit a pull request or open an issue to discuss your changes.

## License

This project is licensed under the MIT License.