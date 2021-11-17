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
        static int IsArOrGeoProg(int[] iArr)
        {

            int flagAr = 0;
            int flagGeo = 0;

            for (int i = 0; i < iArr.Length - 2; i++)
            {
                int a = iArr[i + 1] - iArr[i];
                int a1 = iArr[i + 2] - iArr[i + 1];
                int g = iArr[i + 1] * iArr[i + 1];
                int g1 = iArr[i] * iArr[i + 2];

                if ((a1 - a) != 0)
                {
                    flagAr++;
                }
                if ((g1 - g) != 0)
                {
                    flagGeo++;
                }
                if (iArr[i] == 0)
                {
                    flagGeo++;
                }
            }

            if (flagAr == 0)
            {
                return 1;
            } else if (flagGeo == 0)
            {
                return 2;
            } else return 0;
        }
        static void Main(string[] args)
        {
            bool flag = default;
            string str;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Тема 5. Домашнее задание.\n");
            // Задание 3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 4. Создать метод, принимающий последовательность чисел " +
                "и определяющий является последовательность арифметической или геометрической прогрессией\n");
            Console.ResetColor();
            Console.WriteLine("Введите последовательность чисел, разделённых пробелом\n");

            str = Console.ReadLine();
            var strWithoutSpaces = str.Replace(" ", "");
            flag = int.TryParse(strWithoutSpaces, out int tmp);

            while (flag == false)
            {
                Console.WriteLine("Введите последовательность чисел, свыше 3х элементов разделённых пробелом\n");
                str = Console.ReadLine();
                strWithoutSpaces = str.Replace(" ", "");
                flag = int.TryParse(strWithoutSpaces, out tmp);
            }
            
            int[] iArr = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            flag = false;

            while (iArr.Length < 3)
            {
                while (flag == false)
                {
                    Console.WriteLine("Введите последовательность чисел, свыше 3х элементов разделённых пробелом\n");
                    str = Console.ReadLine();
                    strWithoutSpaces = str.Replace(" ", "");
                    flag = int.TryParse(strWithoutSpaces, out tmp);
                }

                iArr = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            }

            int a = IsArOrGeoProg(iArr);

            if (a == 1)
            {
                Console.WriteLine("Последовательность чисел является арифметической прогрессией\n");
            } else if (a == 2)
            {
                Console.WriteLine("Последовательность чисел является геометрической прогрессией\n");
            } else if (a == 0)
            {
                Console.WriteLine("Последовательность чисел не является ни арифметической ни геометрической прогрессией\n");
            }



                Console.ReadKey();
        }
    }
}
