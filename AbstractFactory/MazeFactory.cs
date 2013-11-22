using System;

namespace AbstractFactory
{
    public class MazeFactory
    {
        public virtual Maze MakeMaze() 
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(Int32 n)
        {
            return new Room(n);
        }

        public virtual Door MakeDoor(Room a, Room b)
        {
            return new Door(a, b);
        }
    }
}
