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
