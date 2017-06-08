using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitce3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Квадрат 2х2
            //диагональ АВ -  А = (-1; -1); В = (1; 1);
            //На вход два действительных числа
            //Определить - внутри квадрата или нет
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x <= 1 && x >= -1 && y <= 1 && y >= -1)
                Console.WriteLine("Точка принадлежит квадрату");
            else
                Console.WriteLine("Точка НЕ принадлежит квадрату");
        }
    }
}
