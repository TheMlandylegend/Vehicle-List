using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using FinalDemo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
     

namespace FinalDemo
{
    public class Automobile : VehicleClasses
    { 
        public Automobile(string model, Color color, int year, int currentMileage, int passengers)
            : base(model,color, year, currentMileage, passengers)
        {

        }
        public String AutomobileInfo()
        {
            return "The model is " + Model + "\nthe color is " + color
                + "\nthe year is " + Year + "\nthe current mileage is " + CurrentMileage
                     + "\nthe amount of seats is " + Passengers
                        ;

        }
        public void Accelerate() => WriteLine($"{Model} is accelerating");

        public override string ToString()
        {
            return this.AutomobileInfo();
        }
        public override object Clone()
        {
            Automobile newVehicle = new Automobile (Model, color, Year, CurrentMileage, Passengers);
            return newVehicle;
        }
        public double DetermineMarketValue()
        {
            double AutombileValue = 100.0;

            if (this.Year > 1999)
                AutombileValue = 2000.0;
            else
                AutombileValue = 1000.0;
            return AutombileValue;
        }

    }
}
