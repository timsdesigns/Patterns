using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implement_Decouple_Classes.InterfaceService
{

    internal class Consumer123
    {
      IService obj;
      public Consumer123(IService temp) => obj = temp;
      public void Execute() => obj.Serve();
    }

}
