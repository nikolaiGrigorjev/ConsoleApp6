using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
        

            //int x1 = 1; // выбераем тип дынных, называем переменнуб х1 и у1 и даем им значение
            //int y1 = 3;
            //char sym1 = '*';//выбераем тип данных для символа , и пишем сам символ
            //Draw(x1, y1, sym1);

            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';
            //Draw(x2, y2, sym2);





            Console.ReadLine();-

        }
        static void Draw(int x, int y, char sym)//отдельная функция чтобы не использовать Копирование кода
        {
            Console.SetCursorPosition(x, y);//выводим на экран 
            Console.Write(sym); // выводим в этой позиции символ
        }

    }
}
