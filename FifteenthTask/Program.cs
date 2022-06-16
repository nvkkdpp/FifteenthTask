﻿using System;

namespace FifteenthTask
{
    public class MyMathFunctions
    {
        public static int Factorial(int value)
        {
            if (value < 0)
            {
                string s = String.Format(
                "Отрицательный аргумент в вызове Factorial {0}",
                value);
                throw new ArgumentException(s);
            }
            int factorial = 1;
            do
            {
                factorial *= value;
            }
            while (--value > 1);
            {
                return factorial;
            }

        }
    }
        public class Program
        {
            public static void Main(string[] args)
            {
                try
                {
                    for (int i = 6; i > -6; i--)
                    {
                        int factorial = MyMathFunctions.Factorial(i);
                        Console.WriteLine("i = {0}, факториал = {1}", i, factorial);
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ФАТАЛЬНАЯ ОШИБКА, ВАМ ГРОЗИТ ДВОЙНОЙ БАН(бан аккаунта навсегда)");
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("Либо ты ща нажмёшь так называемую кнопку <enter>, либо я те нахуй ебалетку разнесу");
                Console.Read();
            }

        }
}
