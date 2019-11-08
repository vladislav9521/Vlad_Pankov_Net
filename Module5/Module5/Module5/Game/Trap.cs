using System;

namespace Module5
{
    class Trap
    {
        private int damage, locationX, locationY;
        private static int minDamage = 1, maxDamage = 10;
        private bool isCharged;

        public Trap()
        {
            isCharged = true;
        }

        public static int MinDamage
        {
            get { return minDamage; }
        }
        public static int MaxDamage
        {
            get { return maxDamage; }
        }
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
        public int Damage
        {
            get { return damage; }
            set
            {
                if (value < 0)
                    damage = minDamage;
                else if (value > maxDamage)
                    damage = maxDamage;
                else damage = value;
            }
        }
        public bool IsCharged
        {
            get { return isCharged; }
            set
            {
                if (!value) this.damage = 0;
                isCharged = value;
            }
        }

        public bool IsExploded(int manLocationX, int manLocationY) => ((manLocationX == this.locationX) && (manLocationY == this.locationY));


    }
}
