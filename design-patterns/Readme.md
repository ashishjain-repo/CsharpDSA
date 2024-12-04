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
Abstraction is used to reduce the complexity by hiding unnecessary details of a class to the user of the class. For example when using a TV remote we do not have to worry about interacting with the circuit board upon button press. We are going to create an email class to demonstrate abstraction. SO currently we have created some methods that are public and user can freely interact with those methods. And to send an email user have to follow all the steps and in an order to send an email. To use abstraction on this we are going to make all the methods private and expose only one method to the user that will complete all the task in an order, and all the complexities are hidden and user do not have to worry about them.

By doing this user has less decisions to make and the program runs in an order and have no need to explicitly tell the program to do the operation in order. If not abstracted user have to make more decision and have to understand more logic before performing and operation or running the program. And in future if our method accepts more parameters or something changes, we only have to make a change once in the implementation which is public, instead of manually going on every line of code and change it.

## Inheritance
Inheritance involves creating a new class (subclass or derived class) based on the existing classes (superclass or baseclass). Subclass inherit properties and behaviours from their superclass and can also add new features or override exisiting ones. Inheritance is often described in termns of an "is-a" relationship.

For example we are using Vehicle as a Base class and Car and Bike as a subclass. In this example every vehicle whether it is Car, or a bike have similar properties as in Vehicle class: Brand, Model, and Year, or methods or functionalities like Start and Stop. But instead of repeating those properties in every class we are making Vehicle parent class and child class will inherit those properties from the base or parent class.
To inherit the class in C# `:` is used with the name of the base class after. 

The use of Inheritance saves us the time to use the similar properties in methods in every class, they can be inheritied from the base class and used as per the subclass is setup, and can also shared the similar methods. If we decide to change one of the methods in that are shared by the other classes, we just have to change it at one place which is parent class and then can be used by other subclasses with new features or changes. But to make changes specific to the subclass, we use the principle of Polymorphism.

## Polymorphism
Polymorphism is the ability of an object to take many forms. We are going to use the same example as perviously with some changes, Vehicle class and multiple subclasses, Car, Motorcycle, and Plane. But this time the base class methods are virtual, which means that sub or child classes can make their own implementation of these methods, by using the same name but differenet behaviour based on the requirment. Child classes can use the same methods but with the word override which means they are changing the behaviour and functionallity of the methods based on the subclass requiremnt but using the same name. But this does not mean they are restricted to use the base methods, they can still use those methods, but they can also override those methods if required.

We are implementing polymorphism, for example we are creating a list of objects of the Vehicles only but we are using List to contain just objects, what will happen is the methods that are available to parent class are not guranteed will work, because it will be a list of objects which could be anything. In this case what we have to do is to check they type of the object if it is an object that has those methods or connected or a part of the parent class. But what happens in this case is, we have to check the type of each and every subclass if it is part of it what should be done, and the list of subclasses could be long and is not efficient.

So now the polymorphism comes in play, what we can do we can make a list of instead of Object, we can do the Parent class, and when we are adding the object in that list, it could only be the type of the subclasses. Now we do not have to go through the extensive checking. Regardless of the objects being part of other classes like Car, Bike, Plane, the list will treat them as an instance of Vehicle.

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
