namespace Activity1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DoorSensor ds1 = new DoorSensor(1, true);
            Console.WriteLine(ds1.ToString());

            TemperatureSensor ts1 = new TemperatureSensor(1,20);
            Console.WriteLine(ts1.ToString());
            */

            var sensors = new List<Sensor>
            {
                new TemperatureSensor(123456, 20),
                new DoorSensor(234567, true),
                new TemperatureSensor(345678, 6.55),
                new DoorSensor(634567, true),
                new TemperatureSensor(1, 9.66),
                new DoorSensor(1, false)
            };

            // Default sorting (ascending)
            sensors.Sort();

            // Sorting with custom comparer (descending)
            sensors.Sort(new Sensor.SortBySerialDescending());

            foreach (var sensor in sensors)
            {
                Console.WriteLine(sensor);
            }
        }
    }
}


