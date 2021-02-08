using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Honda";
            car.Model = "Civic";
            car.Year = "2020";
            car.EngineSize = 1.2;






            var vehicles = new List<IVehicle>() { car };
            
            
            
          foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
                vehicle.Make = "Honda";

                
            }
            
            
            
            
            
            
            
        }
    }
}
