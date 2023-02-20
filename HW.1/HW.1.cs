using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class HW1
    {
        static void Main(string[] args)
        {
            Exception[] exceptions =
            {
                new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым!"),
                new ArgumentNullException("Передаваемый аргумент является null!"),
                new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю!"),
                new FileNotFoundException("Файл не существует!"),
                new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции!")
            };

            foreach (var oops in exceptions)
            {
                try
                {
                    throw oops;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}




