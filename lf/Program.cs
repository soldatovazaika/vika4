using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Линия
            Line line = new Line(0, 5, 3, 6);
            //Окружность
            Circle circle = new Circle(0, 3, 5);
            //Круг
            Round round = new Round(3, 4, 1, "белый");
            //Кольцо
            Ring ring = new Ring(2, 4, 8, 4);
            //Прямоугольник
            Rectangle rectangle = new Rectangle(2, 2, 8, 4);

            List<Figure> figures = new List<Figure>
            {
                line,
                circle,
                round,
                ring,
                rectangle
            };
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Draw());
            }

        }
    }
}