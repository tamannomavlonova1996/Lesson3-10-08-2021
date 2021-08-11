using System;
using System.Data;
using System.Transactions;

namespace Lesson3_10_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 таск
            Console.WriteLine("Выведите сумму покупки:");
            int summa = Convert.ToInt32(Console.ReadLine());
            var skidka = 0;
            if (summa > 500 && summa <= 1000)
            {
                skidka = (3 * summa) / 100;
            
            }
            else if (summa > 1000)
            {
                skidka = (5 * summa) / 100;
            
            }
            
            Console.WriteLine($"Общяя сумма составляет {summa - skidka}");

            // 2 таск
            Console.Write("Выведите первое число:");
            int chis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите второе число:");
            int chis2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите третье число:");
            int chis3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите четвертое число:");
            int chis4 = Convert.ToInt32(Console.ReadLine());
            if (chis1 > chis2 || chis2 > chis3 || chis3 > chis4)
            {
                Console.WriteLine(Math.Min(Math.Min(chis1,chis2),Math.Min(chis3,chis4)));
                
            } 
            else if (chis1 == chis2 && chis2 == chis3 && chis3 == chis4)
            {
                Console.WriteLine(chis1*chis2*chis3*chis4);
            }
              else 
                Console.WriteLine("Числа расположены по возратсанию");

            // 3 таск
            Console.Write("Выведите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите число c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int temp;
            if (a<c)
            {
                temp = c;
                c = a;
                a = temp;
            }

            if (a < b)
            {
                temp = b;
                b = a;
                a = temp;
            }

            if (b < c)
            {
                temp = c;
                c = b;
                b = temp;
            }
            Console.WriteLine($"{a}, {b}, {c}");
            
        }
    }
}

