# dotnet-ntier-architecture
A N-tier back-end architecture that follows Martin Fowler's recomendation using Presentation, Business and Data Access Layer as main layers to separete responsibilities inside code with some GoF patterns to help to achieve manutenability, flexibility and reusability of the code.

## Presentation Layer

This layer handles HTTP requests incoming from any kind of application 

## Business Layer

This layer is where business rules are implemented. The heart of system. The domain logic is organized with Domain Models abstractions and is protected by a Facade. Facade is a GoF Pattern that give us a clean interface to access subsystem functionalities using delegation. 

## Data Access Layer

This layer is responsable for communication between systems, databases and external resources. Where our repositories lies.

## Shared Layer

Any project needs common resources that are shared between all layers. This layer keeps stuffs such Services and Helpers as conversors and formatters.

## Tests

Is very important to have a suite of automated tests in our project to enforce the quality of the code. In this layer there are two projects, one for unitary tests and other for integration tests.

Developed by: Luã Falcão
