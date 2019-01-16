using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        public class Figure
        {
            public virtual double CalcArea()
            {
                throw new System.MethodAccessException("Method not work");
            }
        }

        public class Square : Figure
        {
            private int a;

            public Square(int a)
            {
                this.a = a;
            }

            public override double CalcArea()
            {
                return a * a;
            }
        }

        public class Circle : Figure
        {
            private int rad;

            public Circle(int rad)
            {
                this.rad = rad;
            }

            public override double CalcArea()
            {
                return Math.PI * rad * rad;
            }
        }

        public class Triangle : Figure
        {
            private int a, b;
            private double h;

            public Triangle(int a, int b)
            {
                if (a + a <= b)
                {
                    for (; (a + a) <= b; a++) ;
                }

                this.a = a;
                this.b = b;
                this.h = Math.Sqrt(a * a - (b * b) / 4);

            }

            public override double CalcArea()
            {
                return (b * h) / 2;
            }
        }

        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            Figure[,] mass = new Figure[3, 10];
            Random rnd = new Random();

            for (int i = 0; i <= mass.GetUpperBound(0); i++)
                for (int j = 0; j <= mass.GetUpperBound(1); j++)
                {
                    if (i == 0)
                    {
                        mass[i, j] = new Circle(rnd.Next(1, 10));
                    }
                    else if (i == 1)
                    {
                        mass[i, j] = new Square(rnd.Next(1, 10));
                    }
                    else
                    {
                        mass[i, j] = new Triangle(rnd.Next(1, 10), rnd.Next(1, 10));
                    }
                }

            for (int i = 0; i <= mass.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= mass.GetUpperBound(1); j++)
                {
                    Console.Write(Math.Round(mass[i, j].CalcArea(), 2) + "  ");
                }
                Console.WriteLine();
            }

        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
            FuelCar[] mass = new FuelCar[] {
             new FuelCar {Engine = 1.8f , FuelUsage = 10, Fuel = 45, Distance = 25045},
             new FuelCar {Engine = 2.8f , FuelUsage = 18, Fuel = 60, Distance = 25045},
             new FuelCar {Engine = 0.8f , FuelUsage = 6, Fuel = 40, Distance = 25045},
             new FuelCar {Engine = 1.8f , FuelUsage = 10, Fuel = 50, Distance = 25045}
            };

            bool compare;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine(mass[i].Engine + " < " + mass[j].Engine + " " + (compare = mass[i] < mass[j]));

                    Console.WriteLine(mass[i].Engine + " > " + mass[j].Engine + " " + (compare = mass[i] > mass[j]));

                    Console.WriteLine(mass[i].Engine + " == " + mass[j].Engine + " " + (compare = mass[i] == mass[j]));

                    Console.WriteLine(mass[i].Engine + " != " + mass[j].Engine + " " + (compare = mass[i] != mass[j]));

                }
            }
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
        }
    }
}
