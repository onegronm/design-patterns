- [Design Patterns](#design-patterns)
  * [Creational](#creational)
    + [Factory Method](#factory-method)
    + [Abstract Factory](#abstract-factory)
    + [Builder](#builder)
    + [Singleton](#singleton)
  * [Structural](#structural)
    + [Decorator](#decorator)
    + [Composite](#composite)
    + [Bridge](#bridge)
    + [Adapter](#adapter)
    + [Facade](#facade)
  * [Behavioral](#behavioral)
    + [Strategy](#strategy)
    + [Observer](#observer)
    + [Command](#command)
    + [Iterator](#iterator)
    + [State](#state)
    + [Template Method](#template-method)

<small><i><a href='http://ecotrust-canada.github.io/markdown-toc/'>Table of contents generated with markdown-toc</a></i></small>

# Design Patterns

## Creational
- ### Factory Method
  - *Defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.*
  - Enable the extensible creation of variabilities such as commands, iterators, and visitors.
  - #### Benefits
    - Decouples the implementation of the product from its use.
    - Clients are more flexible since they don't need to specify the class name of the concrete class and the details of its creation.
    - Adding new variants does not affect existing client code.
  - #### Uses and drawbacks
    - When the class cannot anticipate the objects it must create.
    - When the class wants its subclasses to specify the objects it creates.
    - When there's a need to decouple object creation from its subsequent use. 
    - Construction of objects may require additional classes.
- ### Abstract Factory
  - *Provides an interface for creating families of related or dependent objects without specifying their concrete classes.*
  - Methods are often implemented as factory methods. Each method is responsible for creating a concrete product. The subclass of the abstract factory supplies those implementations. 
  - #### Benefits
    - Decouople code from the actual factories that produce products meant for different contexts-such as different regions, operating systems, or looks and feels.
    - Provides a powerful technique for coding to abstractins, not contrete classes.
  - #### Uses and drawbacks
    - When you have families of products you need to create and you want to make sure your clients create products that belong together.
- ### Builder
  - *Encapsulate the construction of a product and allow it to be constructed in steps. Separates construction of a complex object from its representation.*
  - #### Benefits
    - Isolates the code from construction and representation.
    - Fine control over construction process. Allows objects to be constructed in a multistep and varying process (as opposed to one-step factories).
    - Hides internal representation of the product from the client.
    - Product implementations can be swapped in and out because the client only sees an abstract interface.
  - #### Uses and drawbacks
    - When you need to follow a sequence of potentially complex steps to create an object.
    - Allow different implementations and internal interfaces of an object.
    - Goes nicely with interpreter pattern (compound).
    - May involve a lot of classes and class interdependencies.
    - Constructing objects requires more domain knowledge of the client than when using a Factory.
- ### Singleton
  - *Ensures a class has only one instance, and provides a global point of access to it.*
  - Different ways of implementing for thread safety (eager loading, double-checked locking)
  - Examine your performance and resource constraints and carefully choose an appropriate Singleton implementation for multithreaded applications.
  - #### Benefits
    - Provides a global access point to the instance.
  - #### Uses and drawbacks  
    - When you need one and only one instance of an object such as thread pools, connections, caches, dialog boxes, objects that handle preferences and registry settings, objects used for logging, and objects that act as device drivers to devices like printers and graphics cards.
    - When you want to create a single instance lazily.
    - May not be thread-safe depending on the implementation.

## Structural
- ### Decorator
  - *Attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.*
  - Involves a set of decorator classes that are used to wrap concrete components.
  - Decorators mirror the type of the components they decorate, either through inheritance or interface implementation.- Can insert decorators transparently and the client never has to know it's dealing with a decorator.
  - Decorators are typically transparent to the client of the component, unless the client is relying on the component's concrete type.
  - #### Benefits
    - Allows classes to be easily extended to incorporate new behavior without modifying existing code.
    - Objects can be decorated at any time, so we can decorate objects dynamically at runtime with as many decorators as we like.
  - #### Uses and drawbacks
    - When you need to change the behavior of components by adding new functionality before and/or after (or even in place of) delegating to the object it decorates.
    - Adds a lot of small classes to a design and this occasionally results in a design that's less than straightforward for others to understand.
    - Some code is dependent on specific types which can break when introducting a decorator. 
- ### Composite
  - *Build structures of objects in the form of trees to represent part-whole hierarchies that contain both compositions of objects and individual objects as nodes. Using a composite structure, we can apply the same operations over both composites and individual objects, ignoring the differences between composites and individual objects.*
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
  - *Decouple an abstraction from its implementation so that the two can vary independently. This means to create a bridge interface to separate out responsibilities into different abstract classes.*
  - Encapsulate variability behind a stable API that creates separate class hierarchies for an abstraction and its implementations. Client calls to the abstraction are forwarded to the corresponding implementor subclass.
  - The Bridge pattern is an application of the old advice, “prefer composition over inheritance”. 
  - #### Benefits
    - Decouples an implementation so that it is not bound permanently to an interface.
    - Abstraction and implementation can be extended independently.
    - Changes to concrete abstraction classes don't affect the client.
  - #### Uses and drawbacks 
    - Useful any time you need to vary an interface and an implementation in different ways.
    - Useful in graphics and windowing systems that need to run over multiple platforms.
    - When there's a need to change implementor hierarchies at design-time or runtime without breaking client code. 
    - Increases complexity.
 - ### Adapter
   - *Converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.*
   - The job of implementing an adapter is proportional to the size of the interface you need to support as your target interface.
   - Class adapters are different than object adapters. Class adapters subclass the target and adaptee, while with object adapter we use composition to pass requests to an Adaptee. Class adapters require multiple inheritance.
   - Converts one interface to another one a client expects.
   - An adapter wraps an object to change its interface.
   - #### Benefits
     -  Decouples the client from the implemented interface. If we expect the interface to change over time, the adapter encapsulates that change so the client doesn't have to be modified each time it needs to operate against a different interface.
     -  Binds the client to an interface, not an implementation.
     -  Clients can make use of new libraries and subsets without changing any code.
   - #### Uses and drawbacks
     - When you need to adapt an interface to one that the client is expecting.
     - When you need to use an existing class and its interface is not the one you need.
- ### Facade
  - *Provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.*
  - Avoids tight coupling between clients and subsystems.
  - Subsystem classes still remain available for direct use by clients that need to use more specific interfaces.
  - Provides a simplified interface while still exposing the full functionality of the system to those who may need it.
  - Uses delegation to perform the work of the facade.
  - ### Benefits
    - Takes a complex subsystem and makes it easier to use. 
    - Allos updating a subsystem without having to change the client code.
  - ### Uses and drawbacks
    - When you want to hide all the complexity of one or more classes behind a clean, well-lit facade.
    - When you want to decouple your client implementation from any one subsystem.
    - High degree of dependence at facade interface.
    - Complex implementation (especially with existing code).
	
## Behavioral
- ### Strategy
  - *Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.*
  - Change behaviors transparently. Encapsulate variability of behaviors via a common API whose implementations can be changed transparently with respect to clients.
  - #### Benefits
    - Decouples the interface of a behavior from its implementation. It creates an abstraction that makes it easy to select and exchange behaviors.
    - Greater flexibility and reuse.
    - Behaviors can change dynamically.
  - #### Uses and drawbacks
    - When an object should be configurable at runtime with one of many algorithms and all algorithms can be encapsulated and one interface covers all encapsulations.
    - Use as an alternative to subclassing.
    - Overhead of strategy creation and communication. Strategy can increase the number of objects created in a program. 
    - Semantic incompatibility of multiple strategies used together inconsistently. May require other patterns such as abstract factory so groups of strategies that require semantic coherence evolve in a consistent way (concurrent or distributed systems).
- ### Observer
  - *Defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.*
  - Observables (subjects) update observers using a common interface.
  - You can push or pull data from the Observable when using the pattern (pull is considered more "correct").
  - #### Benefits
    - Observers are loosely coupled in that the Observable knows nothing about them, other than that they implement the observer interface.
    - It allows sending data to other objects effectively without any change in the Subject or Observer classes.
    - Observers can be added/removed at any point in time.
  - #### Uses and drawbacks
    - When you need to notify a change of state and push data to several observers.
    - When you need to "listen in" on any types of actions that might occur on a control, like a button press. 
    - Social media, RSS feeds, email subscription in which you have the option to follow or subscribe and you receive latest notification.
    - The Observer interface has to be implemented by ConcreteObserver, which involves inheritance. There is no option for composition.
- ### Command
  - *Encapsulate the request for a service as an object, thereby letting you parameterize other objects with different requests, queue or logs requests, and support undoable operations.*
  - Define objectified actions that enables users to perform command requests consistently and extensibly.
  - Provides a common API for user-request commands.
  - #### Benefits
    - Decouples an object making a request from the one that knows how to perform it.
    - Abstracts the executor of a service making the program more modular and flexible.
    - Can bundle state and behavior in one object or forward behavior to other objects.
    - Can extend behavior via subclassing.
    - Can pass a command object as a parameter.
    - Composition yields macro commands. Macro commands are a simple extension of Command that allow multiple commands to be invoked.
    - Supports arbitrary level undo-redo.
  - #### Uses and drawbacks
    - Implement logging, undo(), and transactional systems.
    - Drawing editors, Microsoft Office tools, GNU Emacs.
    - Might result in lots of trivial command subclasses.
    - Excessive memory may be needed to support undo/redo operations.
    - Avoiding error accumulation during undo/redo in numerical analysis applications.
- ### Iterator
  - *Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.*
  - It also places the task of traversal on the iterator object, not on the aggregate, which simplifies the aggregate interface and implementation, and places the responsibility where it should be.
  - #### Benefits
    - Flexibility. Aggregate and traversal objects are decoupled and can evolve separately.
    - Multiplicity. Supports multiple iterators and traversal algorithms.
  - #### Uses and drawbacks
    - When you require multiple traversal algorithms over an aggregate.
    - When you require a uniform traversal interface over different aggregates.
    - When aggregate classes and traversal algorithms must vary independently.
    - Overhead. Additional communication between iterator and aggregate. Problematic for iterators in concurrent or distributed systems.
    - Dependencies. The iterator implementation may depend on aggregate's implementation.  
- ### State
  - *It allows an object to alter its behavior when its internal state changes. The object will appear to change its class without changing its API.*
  - Represents a state as a full-blown class. The context gets its behavior by delegating to the current state object it is composed with.
  - Allows a Context to change its behavior as the state of the Context changes. This is different from Strategy which typically configures Context classes with a behavior or algorithm. Strategy doesn't have clients accessing the methods through context which is used to store data from the "one size fits all" interface the strategy exposes.
  - #### Benefits
    - By encapsulating each state into a class, we localize any changes that will need to be made and partition behavior for different states.
    - State transitions can be controlled by the State classes or by the Context classes.
  - #### Uses and drawbacks
    - When an object must change its behavior at runtime depending on which state it is in.
    - When several operations have the same large multi-part conditional structure that depends on the object's state.
    - Will typically result in a greater number of classes in your design.
    - Dependencies and interactions may be hard to understand and evolve if they aren't well documented (& if the State pattern isn't well understood)
- ### Template Method
  - *Defines the skeleton of an algorithm in a method, deferring some steps to subclasses. The Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.*
  - Subclasses can "hook into" the algorithm at various points, if they wish through a hook method; a subclass is also free to ignore the hook. Hook methods do nothing or default behavior in the abstract class, but may be overriden in the subclass.
  - The Hollywood Principle guides us to put decision making in high-level modules that can decide how and when to call low-level modules.
  - Similar to strategy as both encapsulate algorithms, one by inheritance and the other by composition.
  - The factory method is a specialization of Template method.
  - #### Benefits
    - Enables inversion of control (Hollywood Principle).
    - Overriding rules are enforced via subclassing.
    - Promotes code reuse.
  - #### Uses and drawbacks 
    - When you need to implement invariant aspects of an algorithm once and let subclasses define variant parts. 
    - When you want to localize common behavior in a class to enhance reuse.
    - When you want to handle variations by subclassing.
    - Must subclass to specialize behavior, which can yield many subclasses. Solves same problems as strategy pattern but in a different way. 


