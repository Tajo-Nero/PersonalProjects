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
            Console.CursorVisible = false;
            ConsoleKeyInfo keynum;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Player player = new Player(new Vector(20, 29));
            Enemy enemy = new Enemy(new Vector(20, 0),100);//일단 피 100,bullet에 데미지 구현해야함
                                                           //player.Playerdesign();
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            
            while (true)
            {
              //Console.WriteLine($"\t\t\t{Timer.Elapsed}");
                if (Console.KeyAvailable)
                {
                    keynum = Console.ReadKey(true);
                    if (keynum.Key == ConsoleKey.Spacebar)
                    {
                        player.PlayerBulletShot();                        
                        enemy.EnemyBulletShot();
                        enemy.MobMove();

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
                
                if (stopwatch.ElapsedMilliseconds > 100)
                {                    
                    player.Update();
                    enemy.EnemyUpdate();
                    stopwatch.Restart();
                }
                
                
                player.Render();
                enemy.EnemyRenser();
                


            }
        }
    }
}
