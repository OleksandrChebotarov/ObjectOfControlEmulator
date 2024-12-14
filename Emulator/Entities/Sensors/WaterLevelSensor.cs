using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class WaterLevelSensor : Sensor
    {
        public override SensorType Type => SensorType.WaterLevel;

        public WaterLevelSensor(string name, string description)
            : base (name, description){}

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 100;
            Console.WriteLine($"{Name} Water Level: {Value:F2} m");
        }
    }
}