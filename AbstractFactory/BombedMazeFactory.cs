using System;

namespace AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(Int32 n)
        {
            return new RoomWithABomb(n);
        }
    }
}
