using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class TurbiditySensor : Sensor
    {
        public override SensorType Type => SensorType.Turbidity;

        public TurbiditySensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 300;
            Console.WriteLine($"{Name} Turbidity: {Value:F2} NTU");
        }
    }
}