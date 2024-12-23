using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Projects
{
    abstract class Enemy
    {
        Vector enemyVector;

        public Vector Vector
        { get { return enemyVector; } set { enemyVector = value; } }
        int enemyHP;
        public int EnemyHP
            { get { return enemyHP; } set { enemyHP = value; } }
        //char _mob = 'θ';
        //public char Mobd
        //{get { return _mob; }set { _mob = value; } }
        public Enemy(Vector vector,int eneHp,char mob)
        { }
        class Boss : Enemy
        {
            public Boss(Vector vec, int bossHp,char bossmob) : base(vec=new Vector(10,10), bossHp, bossmob)
            { }
        }
        class Mob : Enemy
        {
            Bullet[] mobBullet;
            
            public Vector mobVector
             {
                 get { return enemyVector; }
             }
            public Mob(Vector vec, int mobHp,char mob) : base(vec = new Vector(10, 10), mobHp, mob)
            {
                mobBullet = new Bullet[20];
                enemyVector = vec;
                                        
            }
            
        }
    }
}
