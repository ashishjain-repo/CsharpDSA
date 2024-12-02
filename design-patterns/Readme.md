# What are design patterns and why should you learn them?
1. Reusable Solutions
2. Standardized terminology
3. Scalability
4. Maintainability
5. Performance
6. Documentation
7. Best Practices
8. Cross-Domain Applicability

# OOP Principles
## Encapsulation
This is a fundamental principle of OOP, that involves bundeling the data or attributes or field, of methods, or behaviours that operate on the data into a single unit called class. It  helps hiding the internal implementation details, by only exposing the necessary functionalities to the outside world.

For this we have created a file in which we have created a class that represents a bank accoutn in which the Balance is available to be changed, and can be changed to anything which could be a problem if implemented.

So to make this implementation secure and logical we have created another class in which the property balance is private and we have another method to check if the initial deposit amount is acceptable or not, which means greater than zero, which we have added in the constructor of the class. Then we have also added the methods like Withdraw which checks if the amount is less than or equal to zero or greater than the available balance, and a simple method to check the current balance.

This program is stopping the direct user access. Instead user have to create an instance and if the rules are broken the exceptions occurs which prevent the logic to break.

## Abstraction
## Inheritance
## Polymorphism
## Coupling
## Composition

# SOLID Principles
# UML

# Gang of Four (Creational, Structural, Behavioural)
## Creational Patterns
### Abstract Factory
### Builder
### Factory Method
### Prototype
### Singleton

## Structural Patterns
### Adapter
### Bridge
### Composite
### Decorator
### Facade
### Flyweight
### Proxy

## Behavioural Patterns
### Chain of Responsibillity
### Command
### Interpreter
### Iterator
### Mediator
### Memento
### Observer
### State
### Strategy
### Template Method
### Visitor
