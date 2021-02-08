using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 4.2;
        public string Make { get; set; } = "Ford";

        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompantName { get; set; } = "Ford";
        public string Year { get; set; }
        public string Motto { get ; set ; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now drive forwad");
        }

        public void Park()
        {
            Console.WriteLine();
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} now drive revese");
        }
    }
}
