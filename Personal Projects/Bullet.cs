using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Projects
{
    
    class Bullet
    {
        Vector _bulletVector;
        bool _isFired = false;
        //public int _bulletDamg { get; set; }       

        public char _playerShot { get; set; } = '¤';
        public bool IsFired 
        { get { return _isFired; } set { _isFired = value; }}
        public Vector BulletVeactor
        { get { return _bulletVector; } set { _bulletVector = value; } }
        public Bullet(int x, int y)
        {
            _bulletVector = new Vector(x, y);
        }
        
        public void FireOn()
        {
            _isFired = true;
        }
        public void PlayerForward()//플레이어 총알 나가는 방향 위로
        {
            _bulletVector.y--;
        }
        
        public char _mobShot { get; set; } = 'ψ';
        public void EnemyForward()//몹 총알 나가는 방향 아래로
        {
            _bulletVector.y++;
        }

    }
}
