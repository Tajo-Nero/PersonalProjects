using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personal_Projects
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // a @ ＠
            //     @@
            Console.CursorVisible = false;
            ConsoleKeyInfo keynum;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Player player = new Player(new Vector(50, 50));
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    keynum = Console.ReadKey(true);
                    if (keynum.Key == ConsoleKey.Spacebar)
                    {
                        player.Instantiate();
                    }
                    else if (keynum.Key == ConsoleKey.A)
                    {
                        player.MoveLeft();
                    }
                    else if (keynum.Key == ConsoleKey.D)
                    {
                        player.MoveRight();
                    }                    
                }
                if (stopwatch.ElapsedMilliseconds >= 160)
                {                    
                    player.Update();
                    stopwatch.Restart();
                }
                player.Rnder();
            }
        }
    }
}
