namespace Activity1b
{
    internal class DoorSensor : Sensor
    {
        public bool IsOpen { get; set; }

        public DoorSensor(int serial, bool doorStatus) : base(serial) {
            IsOpen = doorStatus;
        }

        public override string CurrentStatus()
        {
            if (IsOpen)
            {
                return "Open";
            }
            else
            {
                return "Closded";
            }
        }

        public override string ToString()
        {
            return $"Door sensor serial is {base.ToString()}, status {CurrentStatus()}";
        }
    }
}
