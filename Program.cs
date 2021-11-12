using System;
using System.Linq;

namespace Homework_5_Source_Task_4
{
    class Program
    {
        /// <summary>
        /// метод, принимающий последовательность чисел и определяющий является последовательность арифметической или геометрической прогрессией
        /// </summary>
        /// <param name="Source">Исходная последовательность</param>
        static void IsArOrGeoProg(string Source)
        {
            int[] iArr = Source.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int flagAr = 0;
            int flagGeo = 0;

            for (int i = 0; i < iArr.Length - 2; i++)
            {
                int a = iArr[i + 1] - iArr[i];
                int a1 = iArr[i + 2] - iArr[i + 1];

                int g = iArr[i + 1] / iArr[i];
                int g1 = iArr[i + 2] / iArr[i + 1];

                if ((a1 - a) != 0)
                {
                    flagAr++;
                }
                if ((g1 - g) != 0)
                {
                    flagGeo++;
                }
            }
            if (flagAr != 0)
            {
                Console.WriteLine("Не является арифметической прогрессией");
            } else Console.WriteLine("Является арифметической прогрессией");

            if (flagGeo != 0)
            {
                Console.WriteLine("Не является геометрической прогрессией");
            }
            else Console.WriteLine("Является геометрической прогрессией");
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Тема 5. Домашнее задание.\n");
            // Задание 3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 4. Создать метод, принимающий последовательность чисел " +
                "и определяющий является последовательность арифметической или геометрической прогрессией\n");
            Console.ResetColor();
            Console.WriteLine("Введите последовательность чисел\n");
            string str = Console.ReadLine();
            IsArOrGeoProg(str);

            Console.ReadKey();
        }
    }
}
