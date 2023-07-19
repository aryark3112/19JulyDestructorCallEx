using System;
namespace _19JulyDestructorEx
{
    public class Emp
    {
        string name;
        public Emp(string name)
        {
            this.name = name;
            Console.WriteLine("Employee Constructor Call");
            Console.WriteLine("Stored Name: \t" + name);
        }
        ~Emp()
        {
            Console.WriteLine("Destructor Call & Name is: \t" +name);
        }
    }
}
