using System;

namespace Personal_Projects
{

    class Enemy
    {

        Vector enemyVector;//몹 좌표
        Bullet[] enemybullet;//몹 총알 배열
        public Vector Vector
        { get { return enemyVector; } set { enemyVector = value; } }
        int enemyHP;
        public int EnemyHP
        { get { return enemyHP; } set { enemyHP = value; } }
        char _mob = 'θ';
        char _mob1 = '{';
        char _mob2 = '}';
        public char Mobd
        { get { return _mob; } set { _mob = value; } }
        public Enemy(Vector vector, int HP)
        {
            enemyHP = HP;
            enemybullet = new Bullet[20];
            enemyVector = vector;
            for (int i = 0; i < enemybullet.Length; i++)
            {
                enemybullet[i] = new Bullet(0, 0);
            }
        }
        public Vector EnemyPos { get { return enemyVector; } }

        public void EnemyBulletShot()//적 Pos로부터 총알 발사 자동으로 쏘게 구현해야함
        {

            for (int i = 0; i < enemybullet.Length; i++)
            {
                if (enemybullet[i].IsFired == true)
                {
                    continue;
                }
                else
                {
                    enemybullet[i].BulletVeactor = enemyVector;
                    enemybullet[i].FireOn();
                    break;
                }
            }
        }
        public void EnemyUpdate()
        {
            for (int i = 0; i < enemybullet.Length; i++)
            {
                if (enemybullet[i].IsFired == true)
                {
                    enemybullet[i].EnemyForward();
                    if (enemybullet[i].BulletVeactor.y > 28) //적 총알이 29보다 커지면 총알제거
                    {
                        enemybullet[i].IsFired = false;
                    }
                }
                else
                {
                    continue;
                }
            }
        }
        public void Mobdesign()
        {
            Console.SetCursorPosition(enemyVector.x, enemyVector.y);
            Console.Write(_mob);
            Console.SetCursorPosition(enemyVector.x - 1, enemyVector.y);
            Console.Write(_mob1);
            Console.SetCursorPosition(enemyVector.x + 2, enemyVector.y);
            Console.Write(_mob2);
        }
        public void MobMove()
        {
            if (EnemyHP > 0)
            {
                LMobMove();
                RMobMove();
                EndMobMove();
            }

        }
        public void LMobMove()
        {

            if (enemyVector.x >= 3)//_mob1 이녀석 날개가 안닿는게 3위치임 3미만은 터진다
                                   //디자인 바꾸던가 해야함 생각해라 현민아
            {
                Mobdesign();
                enemyVector.x -= 3;
                enemyVector.y++;
                
                
            }
        }
        public void RMobMove()
        {
            if (enemyVector.x <= 3)//여기서 +3이되서 메인에 반복문땜에 다시 위로가서 -2 되서 개빡침
            {
                Mobdesign();                
                enemyVector.x += 3;
                enemyVector.y++;
            }
        }
        public void EndMobMove()
        {
            if (enemyVector.y == 29)
            {
                Mobdesign();
                enemyVector.y = 0;
            }
        }
        public void EnemyRenser()//몹 위치하는 곳 출력
        {
            Mobdesign();
            foreach (var shot in enemybullet)
            {
                if (shot.IsFired == true)
                {
                    Console.SetCursorPosition(shot.BulletVeactor.x, shot.BulletVeactor.y+1);//몹로부터 총알발사
                    Console.Write(shot._mobShot);
                }
            }




        }
        //class Boss : Enemy
        //{
        //    public Boss(Vector vec, int bossHp,char bossmob) : base(vec=new Vector(10,10), bossHp, bossmob)
        //    { }
        //}
        //class Mob : Enemy
        //{
        //    Bullet[] mobBullet;
        //    
        //    public Vector mobVector
        //     {
        //         get { return enemyVector; }
        //     }
        //    public Mob(Vector vec, int mobHp,char mob) : base(vec = new Vector(10, 10), mobHp, mob)
        //    {
        //        mobBullet = new Bullet[20];
        //        enemyVector = vec;
        //                                
        //    }
        //    
        //}
    }
}
