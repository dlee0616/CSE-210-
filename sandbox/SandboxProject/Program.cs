using System;

namespace SandboxProject
{
    class Program
    {

        static void Main(string[] args)
        {
           Person info = new Person();
           info.FirstName = "Peter";
           info.LastName = "Lee";
           Console.WriteLine(info.FirstName);  
           Console.WriteLine(info.LastName);  


        }
    }
}
