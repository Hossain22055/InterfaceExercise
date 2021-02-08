using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var vehicles = new List<IVehicle> (){ car };
            
            
            
            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
            }
            
            
            
            
            
            
            
        }
    }
}
