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
        {   /*        
            Map map = new Map();
            map.DrawMap(40,30);
            Console.CursorVisible = false;
            ConsoleKeyInfo keynum;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Player player = new Player(new Vector(20, 29));
            Enemy enemy = new Enemy(new Vector(10, 0),100);//일단 피 100,bullet에 데미지 구현해야함
                                                           //player.Playerdesign();
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            
            while (true)
            {
                map.PrintMap();
              //Console.WriteLine($"\t\t\t{Timer.Elapsed}");
                if (Console.KeyAvailable)
                {
                    keynum = Console.ReadKey(true);
                    if (keynum.Key == ConsoleKey.Spacebar)
                    {
                        player.PlayerBulletShot();                        
                        enemy.EnemyBulletShot();
                        //enemy.MobMove();
                        //enemy.LMobMove();
                        enemy.RMobMove();
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

                map.PrintMap();
                player.Render();
                enemy.EnemyRenser();
                


            }
            */
            Map map = new Map();
            map.DrawMap(28,41);
            map.PrintMap();
            Console.WindowHeight = 31;
            while (true)
            {
                
            }
        }
            
    }
}
