using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число, которое необходимо возвести в степень: ");
                double A = double.Parse(Console.ReadLine());

                double A2 = Math.Pow(A, 2);
                Console.WriteLine($"A^2 = {A2}"); //возводим число в степень 2

                double A4 = Math.Pow(A2, 2);
                Console.WriteLine($"A^4 = {A4}"); //возводим число в степень 4

                double A8 = Math.Pow(A4, 2);
                Console.WriteLine($"A^8 = {A8}"); //возводим число в степень 8

                Console.ReadLine();
            }

            catch 
            { 
                Console.WriteLine("Обнаружена ошибка! Проверьте правильность введённых данных!");

                Console.ReadLine();
            }
        }
    }
}
