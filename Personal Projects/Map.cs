using System;

namespace Personal_Projects
{//12월 24일 맵구현중 머리터지는중
    class Map
    {
        public BaseType[,] _baseMap;
        public int _sizex;//위에서아래
        public int _sizey;//왼에서우
        public enum BaseType
        { space, wall }


        public void DrawMap(int sizex, int sizey)//벽치고 이동공간 확보메서드
        {
            _baseMap = new BaseType[sizex, sizey];
            _sizex = sizex;
            _sizey = sizey;
            for (int x = 0; x < _sizex; x++)
            {
                for (int y = 0; y < _sizey; y++)
                {
                    if (y == 0 || y == _sizey - 1)
                    { _baseMap[x, y] = BaseType.wall; }
                    else
                    { _baseMap[x, y] = BaseType.space; }

                }
            }
        }//된거같은대 확인해봐야함
        public void PrintMap()//일단 맵 듸자인 벽치고 이동할공간 다시 만들어야함
        {

            for (int x = 0; x < _sizex; x++)
            {
                Console.Write(_baseMap[1,39]);
                for (int y = 0; y < _sizey; y++)
                {
                    Console.Write(' ');
                }
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
