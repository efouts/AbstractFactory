using System;

namespace AbstractFactory
{
    public class Room
    {
        public enum Side { North, East, South, West }

        public Room(Int32 n)
        { }

        public void SetSide(Side side, ICanBeTheSideOfARoom @object)
        { }
    }
}
