using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDemo
{
    public class Compact : Automobile
    {
        public Compact(string model,Color color, int year, int currentMileage, int passengers ) : base(model, color, year, currentMileage, passengers)
        {

        }
        public string EngineType { get; set; }
        public int AllWheelDrive { get; set; }
    }
}
