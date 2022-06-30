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