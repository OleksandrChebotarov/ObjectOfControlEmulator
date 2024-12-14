using Emulator.Entities.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities
{
    public class HydroelectricPowerPlant
    {
        public List<Sensor> Sensors { get; set; }

        public HydroelectricPowerPlant()
        {
            Sensors = new List<Sensor>();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors) 
            { 
                sensor.ReadValue();
                Console.WriteLine($"{sensor.Name}: {sensor.Value}");
            }
        }
    }
}