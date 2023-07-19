using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19JulyDestructorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp Obj = new Emp("Sam");
            Obj = null;   //Destructor Call
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadKey();
        }
    }
}
