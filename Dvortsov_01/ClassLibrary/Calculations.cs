using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Calculations 
    {

        /*  Реализовать консольное приложение, вычисляющее значение выражения.
        *   Переменные A,B,C и т.д. должны иметь тип int.
        *   Переменные X,Y,Z,TST должны иметь тип double.
        *   Результат выражения должен выводиться в формате с плавающей запятой.
        *   
        *   Программа должна реализовывать меню, состоящее из 3­х пунктов:
        *           Ввод значений переменных.
        *           Вычисление значения и вывод на экран.​ ​(((A * X div B) * X div C) * X div D) * X
        *           Выход.
        *Выбор элемента меню должен быть реализован нажатием одной клавиши (1, 2 или 3).
        */


        private static int A = 0;
        private static int B = 0;
        private static int C = 0;
        private static int D = 0;
        private static double X = 0;
        private static double Y = 0;
        private static double Z = 0;
        private static double TST = 0;
        public static void inputVariables()
        {
            Console.WriteLine("Enter int A,B,C,D ");
            while (!Int32.TryParse(Console.ReadLine(), out A))
                Console.Write("Неправильное значение. Введите значение переменной A (int): ");

            while (!Int32.TryParse(Console.ReadLine(), out B))
                Console.Write("Неправильное значение. Введите значение переменной B(int): ");

            while (!Int32.TryParse(Console.ReadLine(), out C))
                Console.Write("Неправильное значение. Введите значение переменной C(int): ");

            while (!Int32.TryParse(Console.ReadLine(), out D))
                Console.Write("Неправильное значение. Введите значение переменной D(int): ");

            Console.WriteLine("Double  X,Y,Z ");

            while (!Double.TryParse(Console.ReadLine(), out X))
                Console.Write("Неправильное значение. Введите значение переменной X(double): ");

            while (!Double.TryParse(Console.ReadLine(), out Y))
                Console.Write("Неправильное значение. Введите значение переменной Y(double): ");

            while (!Double.TryParse(Console.ReadLine(), out Z))
                Console.Write("Неправильное значение. Введите значение переменной Z(double): ");

        }
        public static void calculateAndShowResult()
        {
            Console.WriteLine("Вычисление выражения :");
            Console.WriteLine("                      (((A * X div B) * X div C) * X div D) * X");
            TST = (((A * X / B) * X / C) * X / D) * X;
            Console.WriteLine("Результат :");
            Console.WriteLine(TST);
        }
    }
}

