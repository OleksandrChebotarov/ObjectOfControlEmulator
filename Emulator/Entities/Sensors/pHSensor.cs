using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class pHSensor : Sensor
    {
        public override SensorType Type => SensorType.pH;

        public pHSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * (8.5 - 6.5) + 6.5;
            Console.WriteLine($"{Name} pH Level: {Value:F2}");
        }
    }
}