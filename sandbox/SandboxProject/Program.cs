using System;

namespace SandboxProject
{
    class Program
    {

        static void Main(string[] args)
        {
           Person info = new Person();
           
           info.SetFirstName("Peter");
           
           info.SetLastName("Lee");

           Console.WriteLine(info.GetFirstName());  
           Console.WriteLine(info.GetLastName());  


        }
    }
}
