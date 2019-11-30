using System;
using System.Text;


namespace Module5
{
    class PlayingField
    {
        public static int countTrap = 10;
        const int fieldDimention = 10;

        private Trap[] traps;

        public Trap this[int count]
        {
            get { return traps[count]; }
            set { traps[count] = value; }
        }

        public PlayingField()
        {
            traps = new Trap[countTrap];
            MineField(traps);

        }

        public void DrawField()
        {
            string tlCorner = "╔";
            string blCorner = "╚";
            string trCorner = "╗";
            string brCorner = "╝";
            string verticalSide = "║";
            string horizontalSide = "═══";

            string str = string.Empty;

            for (int width = 0; width < fieldDimention; width++)
            {
                str += tlCorner + horizontalSide + trCorner;
            }
            StringBuilder row = new StringBuilder();
            row.AppendLine(str);

            str = string.Empty;
            for (int width = 0; width < fieldDimention; width++)
            {
                str += verticalSide + "   " + verticalSide;
            }
            row.AppendLine(str);

            str = string.Empty;
            for (int width = 0; width < fieldDimention; width++)
            {
                str += blCorner + horizontalSide + brCorner;
            }
            row.AppendLine(str);

            for (int width = 0; width < fieldDimention; width++)
            {
                Console.Write(row);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((int)Wall.MaxX, (int)Wall.MaxY);
            Console.Write((char)12);
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < countTrap; i++)
            {
                if (!traps[i].IsCharged)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(traps[i].LocationX, traps[i].LocationY);
                    Console.Write((char)1);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        private void MineField(Trap[] traps)
        {
            Random random = new Random();

            ReAssign:

            for (int i = 0; i < countTrap; i++)
            {
                do
                {
                    traps[i] = new Trap
                    {
                        LocationX = (int)Wall.MinX + random.Next(0, 10) * (int)Step.Right,
                        LocationY = (int)Wall.MinY + random.Next(0, 10) * (int)Step.Down,
                        Damage = random.Next(Trap.MinDamage, Trap.MaxDamage + 1)
                    };
                }
                while ((traps[i].LocationX == (int)Wall.MinX && traps[i].LocationY == (int)Wall.MinY)
                    || (traps[i].LocationX == (int)Wall.MaxX && traps[i].LocationY == (int)Wall.MaxY));
            }

            for (int i = 0; i < countTrap - 1; i++)
            {
                for (int j = i + 1; j < countTrap; j++)
                {
                    if( (traps[i].LocationX == traps[j].LocationX) &&
                        (traps[i].LocationY == traps[j].LocationY) )
                    {
                        Console.Title += "!!";
                        goto ReAssign;
                    }
                }
            }
        }
    }
}
