# Design-Pattern
## Creational
### Factory pattern
    -> defines an interface for creating an object
    -> doesn't specify what object individual implementation of the the interface will instantiate.
    -> use anytime you need to create group of related objects.
    
    **Particpants:**
    1. Product: defines the interface of object
    2. ConcreteProduct: implements the interface
    3. Creator: declares the factory method which return object type
    4. ConcreteCreator: ovverides the factory to return concrete product.
    
### Abstract Factory
    -> defines interfaces for creating families of related objects without specifying the actual implementations.
    -> Enables Dependency Injection
    
    ** Particapants: **
    1. AbstractFactory: declares an interface for operations which will create AbstractProduct objects.
    2. ConcreteFactory: implements the operations defined by the AbstractFactory.
    3. AbstractProduct: declares an interface for a type of product.
    4. Products: defines a product object that will be created by the corresponding ConcreteFactory.
    5. Client: uses the AbstractFactory and AbstractProduct interfaces.
