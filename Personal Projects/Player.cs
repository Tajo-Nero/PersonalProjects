using System;

namespace Personal_Projects
{

    class Player
    {
        Bullet[] bullets;
        Vector CorePos;
        Vector LeftPos;
        Vector RightPos;
        Vector HeadPos;


        public char _playercore { get; set; } = 'Ω';
        public char _playerLeft { get; set; } = '>';
        public char _playerRight { get; set; } = '<';
        public char _playerHead { get; set; } = 'Λ';
        public Player(Vector plavator)//생성과 동시에 총알 20개 생성
        {            
            bullets = new Bullet[20];
            CorePos = plavator;            
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet(0,0);
            }
        }
        //public void Playerdesign()//임시디자인
        //{
        //    Console.WriteLine(" " + _playerHead);
        //    Console.Write(_playerRight);
        //    Console.Write(_playercore);
        //    Console.Write(_playerLeft);
        //}


        public Vector PlayerCore//플레이어 좌표 움직일때 뒤에 남는거 제거해야함
        { get { return CorePos; } }
        public Vector PlayerLeft
        { get { return LeftPos; } }
        public Vector PlayerRight
        { get { return RightPos; } }
        public Vector HeadCore
        { get { return HeadPos; } }
       
        public void MoveLeft()
        {
            CorePos.x -= 2;
            if (CorePos.x <= 0)
            { CorePos.x = 2; } 
            //코어의 좌표 고정 0보다 코어+Right =2니까 =2로
            //고정시키면 옆으로 더안간다 x축이 0이되면
        }
        public void MoveRight()
        {
            CorePos.x += 2;
            //위에처럼 나중에 맵만들때 오른쪽도 작업하자
        }
        public void PlayerBulletShot()//플레이어 코어로부터 총알 발사
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == true)
                {
                    continue;
                }
                else
                {
                    bullets[i].BulletVeactor = PlayerCore;
                    bullets[i].FireOn();
                    break;
                }

            }
        }
        public void Update()
        {
           Console.Clear();
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == true)
                {
                    bullets[i].PlayerForward();
                    if (bullets[i].BulletVeactor.y < 1) //y 좌표가 0보다 작아지면 총알 제거
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

        public void Render()//플레이어 위치보여주는 메서드
        {
            Console.SetCursorPosition(CorePos.x, CorePos.y);
            Console.Write(_playercore);
            Console.SetCursorPosition(CorePos.x+2, CorePos.y);
            Console.Write(_playerLeft);
            Console.SetCursorPosition(CorePos.x-1, CorePos.y);
            Console.Write(_playerRight);
            Console.SetCursorPosition(CorePos.x, CorePos.y-1);
            Console.Write(_playerHead);
            foreach (var shot in bullets)
            {
                if (shot.IsFired == true)
                {
                    Console.SetCursorPosition(shot.BulletVeactor.x, shot.BulletVeactor.y-1);//코어가 기준
                    Console.Write(shot._playerShot);
                }
            }


        }
    }
}
