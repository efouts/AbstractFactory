using System;

namespace AbstractFactory
{
    public abstract class EnchantedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(Int32 n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public override Door MakeDoor(Room a, Room b)
        {
            return new DoorNeedingSpell(a, b);
        }

        protected abstract Spell CastSpell();
    }
}
