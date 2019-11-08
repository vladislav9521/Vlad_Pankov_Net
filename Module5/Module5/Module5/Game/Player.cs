using System;

namespace Module5
{
    class Player
    {
        private const int maxHealth = 10;
        private int locationX;
        private int locationY;
        private int health;

        public int LocationX
        {
            get { return locationX; }
            set
            {
                if (value < (int)Wall.MinX)
                    locationX = (int)Wall.MinX;
                else if (value > (int)Wall.MaxX)
                    locationX = (int)Wall.MaxX;
                else locationX = value;
            }
        }
        public int LocationY
        {
            get { return locationY; }
            set
            {
                if (value < (int)Wall.MinY)
                    locationY = (int)Wall.MinY;
                else if (value > (int)Wall.MaxY)
                    locationY = (int)Wall.MaxY;
                else locationY = value;
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > 10)
                    health = 10;
                else health = value;
            }
        }

        public Player()
        {
            health = maxHealth;
            locationX = (int)Wall.MinX;
            locationY = (int)Wall.MinY;
        }

        public void Move()
        {
            Console.SetCursorPosition(locationX, locationY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write((char)11);
            Console.ForegroundColor = ConsoleColor.Gray;

            ConsoleKeyInfo k = Console.ReadKey(true);

            if (k.Key == ConsoleKey.UpArrow)
                LocationY -= (int)Step.Up;
            else if (k.Key == ConsoleKey.DownArrow)
                LocationY += (int)Step.Down;
            else if (k.Key == ConsoleKey.LeftArrow)
                LocationX -= (int)Step.Left;
            else if (k.Key == ConsoleKey.RightArrow)
                LocationX += (int)Step.Right;

            Console.Clear();
        }
    }
}
