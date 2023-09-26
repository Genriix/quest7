using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest7
{
    internal class Program
    {
        ///////////////////////////////////////////  1  ////////////////////////////////////////


        static string Calculate(int a, int b, int c)
        {
            return $"Среднее арифметическое этих чисел: {(a + b + c) / 3}";
        }


        ///////////////////////////////////////////  2  ////////////////////////////////////////


        static string Add(int x, int y)
        {
            return $"Сумма чисел: {x + y}";
        }

        static string Sub(int x, int y)
        {
            return $"Разность чисел: {x - y}";
        }

        static string Mul(int x, int y)
        {
            return $"Результат умножения: {x * y}";
        }

        static string Div(double x, double y)
        {
            if (y != 0)
            {
                return $"Результат деления: {Convert.ToString(Math.Round(x / y, 2))}";
            }
            else
            {
                return "Обнаружено деление на 0";
            }

        }


        ///////////////////////////////////////////  3  ////////////////////////////////////////


        static string Monetochki()
        {
            Console.Write("Введите валюту (рубли): ");
            double rub = double.Parse(Console.ReadLine());
            Console.Write("Введите курс доллара: ");
            double rate = double.Parse(Console.ReadLine());

            string usd = Convert.ToString(Math.Round(rub / rate, 2));
            return $"У вас есть {usd} долларов";

        }


        ///////////////////////////////////////////  4  ////////////////////////////////////////


        static string Pol_ot(int i)
        {
            if (i > 0)
            {
                return "Число положительное";
            }
            else if (i < 0)
            {
                return "Число отрицательное";
            }

            else
            {
                return "Число 0";
            }

        } 

        static string Prost(int i)
        {
            if (i / 1 == i && i / i == 1 && i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 5 != 0)
            {
                return ("Простое");
            }
            else { return ("Не простое"); }
        }

        static string Div(double i)
        {
            string div_2 = "", div_3 = "", div_5 = "", div_6 = "", div_9 = "";

            if ((i % 2) == 0) { div_2 = "Делится на 2 без остатка"; }
            else { div_2 = "Не делится на 2 без остатка"; }

            if ((i % 3) == 0) { div_3 = "Делится на 3 без остатка"; }
            else { div_3 = "Не делится на 3 без остатка"; }

            if ((i % 5) == 0) { div_5 = "Делится на 5 без остатка"; }
            else { div_5 = "Не делится на 5 без остатка"; }

            if ((i % 6) == 0) { div_6 = "Делится на 6 без остатка"; }
            else { div_6 = "Не делится на 6 без остатка"; }

            if ((i % 9) == 0) { div_9 = "Делится на 9 без остатка"; }
            else { div_9 = "Не делится на 9 без остатка"; }

            return $"{div_2} \n{div_3} \n{div_5} \n{div_6} \n{div_9}\n";
;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("\nЗадание 1"); /////////////////////////  1  ////////////////////////


            Console.WriteLine("Введите три числа: ");
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, b, c));


            Console.WriteLine("\nЗадание 2"); /////////////////////////  2  ////////////////////////


            Console.WriteLine("Введите два числа: ");
            int oper1 = int.Parse(Console.ReadLine()), oper2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(oper1, oper2) + "\n" + Sub(oper1, oper2) + "\n" + Mul(oper1, oper2) + "\n" + Div(oper1, oper2));


            Console.WriteLine("\nЗадание 3"); /////////////////////////  3  ////////////////////////


            Console.WriteLine(Monetochki());


            Console.WriteLine("\nЗадание 4"); /////////////////////////  4  ////////////////////////
            

            Console.Write("\nВведите число: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Prost(input) + "\n" + Pol_ot(input) + "\n" + Div(input));


            Console.ReadKey();

            //______      ______   ______          ______         ___________     ______     __________    ______   ______
            //\     \    /     /  /     /         /      \       |           \   |      |   /          \  |      | /     /
            // \     \  /     /  /     /         /        \      |            \  |      |  /     ______/  |      |/     /
            //  \     \/     /  /     /         /          \     |      |     |  |      |  |    |         |            |
            //   \          /  /     /_____    /     /\     \    |      |     |  |      |  |    |______   |             \
            //    \        /  /            /  /      __      \   |            /  |      |  \           \  |      |\      \
            //     \______/  /____________/  /______/  \______\  |___________/   |______|   \__________/  |______| \______\

        }
    }
}
