using System;

namespace example 
{
    //parent class car 
    public class car 
    {
        public string brand = "infiniti";
      

        public void engine()
        {
            Console.WriteLine("vroom,Vroom");
        }

    }
    //child class vehicle
    public class Vehicle : car 
    {
        public string model = "g35";
    }
    public class program 
    {
        public void main (string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            myVehicle.engine();
            Console.WriteLine(myVehicle.brand,"", myVehicle.model);
        }

    }


}