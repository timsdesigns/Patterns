using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implement_Decouple_Classes.InterfaceService
{

    internal class Server : IService
    {
      public void Serve() => Console.WriteLine("Server executes");
    }

}
