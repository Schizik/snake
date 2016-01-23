using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.SetBufferSize(120, 30);

            //Отрисовка рамочки

            HorizontalLine upLine = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 118, 29, '+');
            VerticalLine leftline = new VerticalLine(0, 29, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 29, 118, '+');
            upLine.Drow();
            downLine.Drow();
            leftline.Drow();
            rightLine.Drow();
            
            //Отрисовка точки
            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Console.ReadLine();
            //Console.ReadLine();
        }
    }
}
