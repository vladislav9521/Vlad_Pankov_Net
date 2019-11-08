using System;

namespace Module5
{
    class Game
    {
        PlayingField field;
        Player player;

        public Game()
        {
            field = new PlayingField();
            player = new Player();
        }

        public void Run()
        {

            while (true)
            {

                for (int i = 0; i < PlayingField.countTrap; i++)
                {
                    if (field[i].IsExploded(player.LocationX, player.LocationY))
                    {
                        player.Health -= field[i].Damage;
                        field[i].IsCharged = false;
                    }
                }

                Console.Title = string.Format($"Location: {((player.LocationX - (int)Wall.MinX) / (int)Step.Right) + 1};" +
                                             $"{ ((player.LocationY - (int)Wall.MinY) / (int)Step.Down) + 1} Health: {player.Health}" +
                                             $" Player: {(char)11}; Princess: {(char)12}; Mines: ☺, To control player use ←, ↑, →, ↓");


                field.DrawField();
                player.Move();

                if (player.Health == 0)
                {
                    field.DrawField();
                    Console.WriteLine("PLAYER IS DEAD, GAME IS OVER!!!");
                    break;
                }
                else if ((player.LocationX == (int)Wall.MaxX && player.LocationY == (int)Wall.MaxY))
                {
                    field.DrawField();
                    Console.WriteLine("PRINCESS IS SAVED, YOU WON!!!");
                    break;
                }


            }
        }

    }
}

