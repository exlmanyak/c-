using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Program
{
    class Program
    {
        static void Main()
        {
            bool b2 = true; // Вызывался ли ввод значений
            char menu = '1'; 

            while (menu != '3') 
            {
                Console.Clear();
                Console.WriteLine("Програма вычисляет значение выражения:(((A * X div B) * X div C) * X div D) * X\n1 - Ввод данных\n2 - Вычисление\n3 - Выход");
                 menu = Console.ReadKey().KeyChar;

                if (menu == '1')
                {
                    Console.Clear();
                    ClassLibrary.Calculations.inputVariables();
                    b2 = false;
                }
                else 
                    if (menu == '2')
                {
                    Console.Clear();
                    if (b2)
                    {
                        Console.WriteLine("Сначалa введите данные\nНажмите любую клавишу для выхода в меню");
                        Console.ReadKey();
                    }
                    else
                        Calculations.calculateAndShowResult();
                    Console.ReadKey();
                }
                else 
                        if (menu !='3')
                {
                    Console.Clear();
                    Console.WriteLine("Недоступная команда\nНажмите любую клавишу для выхода в меню");
                    Console.ReadKey();

                }
            };
            Console.WriteLine("Конец работы программы");
            Console.ReadKey();
        }
    }
}
