using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Point
    {//class тип данных целые числа или символы, хранит данные
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);//выводим на экран 
            Console.Write(sym); // выводим в этой позиции символ

        }

    }
}
