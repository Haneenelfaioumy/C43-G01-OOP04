using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Manager : Employee
    {
        // Overriding the Work method in the derived class
        public override void Work()
        {
            // Calling the Work method of the Employee class
            base.Work();
            Console.WriteLine("Manager is managing");
        }
    }
}
