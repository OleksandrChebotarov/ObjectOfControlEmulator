using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class PressureSensor : Sensor
    {
        public override SensorType Type => SensorType.Pressure;

        public PressureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * (20 - 1) + 1;
            Console.WriteLine($"{Name} Pressure: {Value:F2} atm");
        }
    }
}