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
        public char _playerShot { get; set; } = 'º';
        public bool IsFired 
        { get { return _isFired; } set { _isFired = value; }}
        public Vector BullVeactor
        { get { return _bulletVector; } set { _bulletVector = value; } }
        public Bullet(int x, int y)
        {
            _bulletVector = new Vector(x, y);
        }
        public void FireOn()
        {
            _isFired = true;
        }
        public void MoveForward()
        {
            _bulletVector.y--;//위로 쏘는대 콘솔 위에 맞으면 터짐
        }

    }
}
