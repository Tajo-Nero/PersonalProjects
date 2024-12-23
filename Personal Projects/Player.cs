using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Projects
{
    
    class Player
    {
        Bullet[] bullets;
        Vector playerPos;
        public char _playercore { get; set; } = '●';
        public Player(Vector plavator)//생성과 동시에 총알 5개 생성
        {
            bullets = new Bullet[20];
            playerPos = plavator;
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet(0,0);
            }
        }
        public Vector PlayerPos//플레이어 좌표 움직일때 뒤에 남는거 제거해야함
        {
            get { return playerPos; }
        }
        public void MoveLeft()
        {
            playerPos.x -=2;
        }
        public void MoveRight()
        {
            playerPos.x +=2;
        }
        public void Instantiate()
        {
            for (int i = 0; i < bullets.Length;i ++)
            {
                if (bullets[i].IsFired == true)
                {
                    continue;
                }
                else
                {
                    bullets[i].BullVeactor = playerPos;
                    bullets[i].FireOn();
                    break;
                }

            }
        }
        public void Update()
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == true)
                {
                    bullets[i].MoveForward();
                    if (bullets[i].BullVeactor.y > 100)
                    {
                        bullets[i].IsFired = false;
                    }

                }
                else
                {
                    continue;
                }
            }
        }
        public void Rnder()//플레이어 위치보여주는 메서드
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.Write(_playercore);

           foreach (var shot in bullets)
            {
                if (shot.IsFired == true)
                {
                    Console.SetCursorPosition(shot.BullVeactor.x, shot.BullVeactor.y);
                    Console.Write(shot._playerShot);
                }
            }


        }
    }
}
