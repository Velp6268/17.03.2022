using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp12
{
    internal class Program
    {
     

        static void Main(string[] args)
        {
            int[] Arr = new[] { 1, 3, 2, 5, 6, 11, 9 };

            Console.WriteLine("\n1.Показать массив " +
                "\nВведите номер действия: ");
            int var = int.Parse(Console.ReadLine());


            switch (var)
            {
                case 1:
                    Task3.PrintMass(Arr);
                    break;
            }

            Console.WriteLine("\nМассив из 7 элементов: \n");

            

            int a, b;
            Console.Write("\n\nВведите целое число a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите целое число b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nЭлементы из интервала [{a}, {b}]: \n");

            int count = Task3.Pick(Arr, a, b);




            Task3.Check(count);


            Console.ReadLine();
        }
    }
}

