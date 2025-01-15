using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class DerivedClass1 : BaseClass
    {
        // Overriding the method in DerivedClass1
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }
}
