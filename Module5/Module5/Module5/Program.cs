using System;

namespace Module5
{
    //Необходимо создать в консоли поле 10х10.Игрок должен дойти до противоположного конца поля, 
    //    где его ждет принцесса.У игрока есть 10 очков жизней. На поле рандомно выставлены 10 ловушек,
    //        урон которых определяется случайным образом (от 1 до 10). Ловушки на поле не видны, игрок 
    //    ходит вслепую.За границы не выходит.После смерти или победы игра предлагает еще одну сессию.

    class Program
    {

        static void Main(string[] args)
        {         
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 35);

            ConsoleKeyInfo k;
            do
            {
                Console.Clear();
                new Game().Run();

                Console.WriteLine("Press ESC tp exit. Press any key except ESC to continue...");
                k = Console.ReadKey(true);
            }
            while (k.Key != ConsoleKey.Escape);

            Console.ReadKey();
        }

    }
}
