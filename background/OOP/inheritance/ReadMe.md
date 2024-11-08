# Abstract Classes
An abstract class cannot be instantiated directly, it is designed to be inherited by other classes. You can define these methods in the Abstract class:-
* **Abstract Methods**: These methods are just the signature without any implimentation, so when used in the subclasses they need to be overriden and provide a body.
* **Concrete Methods**: These methods are fully defined, which subclasses can inherit them as-is or then can override it and cistomize the body based on the usecase. These are generally marked as Virtual and can be overriden if they are created as virtual.

# Virtual Methods
Virtual methods in a base classes provides a default implementation, but they can be overriden by derived classes.  This allow sub-classes or child-classes to modify the behaviour of the methods.

# Interfaces
Interfaces define a contract that unrelated classes can implement, which promotes flexibillity. One can also inherot multiple interfaces, where one can only inherit one base class. Interfaces gives the flexibillity to choose how the class should act instead of dictating what must be done as a base class. We have to make sure if adding an interface is the right choice to our program, because it can cause the repetition in the program.