# Design Patterns

## Creational
- Simple Factory
- Factory Method
- Abstract Factory

## Structural
- Decorator
- ### Composite
  - Build structures of objects in the form of *trees* to represent part-whole hierarchies that contain both compositions of objects and individual objects as nodes. Using a composite structure, we can apply the same operations over both composites and individual objects, ignoring the differences between composites and individual objects.
  - #### Benefits
    - Treat individual objects and multiple, recursively-composed objects uniformly regardless of complexity and behavior.
    - No distinction between individual and composed elements. 
    - New component subclasses work wherever existing ones do.
    - Classes only include fields and methods they need.
  - #### Uses and drawbacks 
    - Let clients treat individual objects and compositions as objects uniformly.
    - Perceived complexity. May need what seems a large number of classes and objects.
    - Bloated interfaces for composites and leaves. Leaf inherits methods it doesn't need.
- ### Bridge
  - Decouple an abstraction from its implementation so that the two can vary independently. This means to create a bridge interface to separate out responsibilities into different abstract classes.
  - Encapsulate variability behind a stable API that creates separate class hierarchies for an abstraction and its implementations. Client calls to the abstraction are forwarded to the corresponding implementor subclass.
  - #### Benefits
	- Decouples an implementation so that it is not bound permanently to an interface.
	- Abstraction and implementation can be extended independently.
	- Changes to concrete abstraction classes don't affect the client.
  - #### Uses and drawbacks 
	- Useful any time you need to vary an interface and an implementation in different ways.
	- Useful in graphics and windowing systems that need to run over multiple platforms.
	- When there's a need to change implementor hierarchies at design-time or runtime without breaking client code.
	- Increases complexity.
	
## Behavioral
- Strategy
- Observer
- Command
