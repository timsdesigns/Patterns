
# Design Patterns `(in C#)`

[Design Patterns For Beginners article series 2018](https://www.c-sharpcorner.com/UploadFile/dacca2/design-pattern-for-beginner-part-1-singleton-design-patt/)

 # Content
 - [Singleton Design Pattern](#singleton-design-pattern-creational)
 - [Factory Design Pattern](#factory-design-pattern-creational)
 - [Prototype Design Pattern](#prototype-design-pattern-creational)
 - [Decorator Design Pattern](#decorator-design-pattern-structural)
 - [Composite Design Pattern](#composite-design-pattern-structural)
 - [Adaptor Design Pattern](#adaptor-design-pattern-structural)
 - [Bridge Design Pattern](#bridge-design-pattern-structural)
 - [Memento Design Pattern](#memento-design-pattern-behavioral)
 - [Strategy Design Pattern](#strategy-design-pattern-behavioral)
 - [Observer Design Pattern](#observer-design-pattern-behavioral)
 - [Implement Decouple Classes in Application](#implement-decouple-classes-in-application)

---
<a href=https://www.dotnetcurry.com/microsoft-azure/microservices-architecture>
 <img src=https://www.dotnetcurry.com/images/azure/microservices/architecture-patterns.png width=400>
</a>
<a href=https://www.dotnetcurry.com/patterns-practices/dotnet-application-architecture>
 <img src=https://www.dotnetcurry.com/images/dotnetcore/app-architecture/software-architecture-designs.png width=400>
</a>
<img src=https://usercontent.one/wp/scientificprogrammer.net/wp-content/uploads/2020/01/design-patterns-16-728.jpg width=400>
---

 ## Singleton Design Pattern `[Creational]` [^](#content)
 >a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created
 ## Factory Design Pattern `[Creational]` [^](#content)
 ## Prototype Design Pattern `[Creational]` [^](#content)
 ## Decorator Design Pattern `[Structural]` [^](#content)
 ## Composite Design Pattern `[Structural]` [^](#content)
 ## Adaptor Design Pattern `[Structural]` [^](#content)
 ## Bridge Design Pattern `[Structural]` [^](#content)
 ## Memento Design Pattern `[Behavioral]` [^](#content)
 ## Strategy Design Pattern `[Behavioral]` [^](#content)
 ## Observer Design Pattern `[Behavioral]` [^](#content)
 ## [Implement Decouple Classes in Application](https://www.c-sharpcorner.com/UploadFile/dacca2/design-pattern-for-beginner-part-11-implement-decouple-cl/)
  - ![](Implement%20Decouple%20Classes/ClassDiagram1.png)
  ```csharp
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  namespace Implement_Decouple_Classes.InterfaceService
  {
    public interface IService  
    {  
      void Serve();  
    }  
    public class Server : IService  
    {  
      public void Serve() => Console.WriteLine("Server executes");
    }  
    public class Consumer  
    {  
      IService obj;  
      public Consumer123(IService temp) => obj = temp;
      public void Execute() => obj.Serve();
    }  
  }
  ```
  ```csharp
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using Implement_Decouple_Classes.InterfaceService;

  namespace Implement_Decouple_Classes.DependencyInjection
  {
    class Program
    {
      static void Main(string[] args)
      {
        // Consumer oblivient of constructor argument
        //  - (any concrete class implementing IService)
        // Server oblivient of Consumer class
        //  - decoupled!
        Consumer123 C = new Consumer123(new Server());
        C.Execute();
        Console.ReadLine();
      }
    }
  }
  ```