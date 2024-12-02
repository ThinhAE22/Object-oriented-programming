namespace Activity1b
{
    internal class TemperatureSensor : Sensor
    {
        public double Temperature { get; set; }

        public TemperatureSensor(int serial, double temperature) : base(serial)
        {
            Temperature = temperature;
        }

        public override string CurrentStatus()
        {
            return Temperature.ToString();
        }

        public override string ToString()
        {
            return $"Temperature sensor serial is {base.ToString()}, status {CurrentStatus()} Celsius";
        }
    }
}
