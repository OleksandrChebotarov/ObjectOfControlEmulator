using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class FlowRateSensor : Sensor
    {
        public override SensorType Type => SensorType.FlowRate;

        public FlowRateSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * (10 - 0.1) + 0.1;
            Console.WriteLine($"{Name} Flow Rate: {Value:F2} m/s");
        }
    }
}