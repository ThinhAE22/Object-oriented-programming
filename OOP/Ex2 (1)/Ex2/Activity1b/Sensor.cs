using System;
using System.Collections.Generic;

namespace Activity1b
{
    public abstract class Sensor : IComparable<Sensor>
    {
        // Property for Serial with validation
        private int _serial;
        public int Serial
        {
            get => _serial;
            set
            {
                if (value >= 100000 && value <= 999999)
                {
                    _serial = value;
                }
                else
                {
                    _serial = -1; // Invalid serial number
                }
            }
        }

        // Constructor
        protected Sensor(int serial)
        {
            Serial = serial;
        }

        // Abstract method for status
        public abstract string CurrentStatus();

        // ToString override
        public override string ToString()
        {
            return $"Sensor Serial: {Serial}";
        }

        // IComparable implementation
        public int CompareTo(Sensor other)
        {
            // Compare serial numbers directly
            return Serial.CompareTo(other.Serial);
        }

        // Custom comparer class for reverse sorting
        public class SortBySerialDescending : IComparer<Sensor>
        {
            public int Compare(Sensor x, Sensor y) // basically return 1 0 -1 and order them with the priority
            {
                // Reverse sorting by serial
                return y.Serial.CompareTo(x.Serial);
            }
        }
    }
}
