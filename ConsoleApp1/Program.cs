using System;
namespace New_5_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrayFromConsole();
            SortArray(in arr, out int[] sorteddesc, out int[] sortedasc);

            Console.Write("Сортировка по убыванию: ");
            foreach (int i in sorteddesc)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nСортировка по возрастанию: ");
            foreach (int i in sortedasc)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        static void SortArray(in int[] array, out int[] SortedDesc, out int[] SortedAsc)
        {
            SortedDesc = SortArrayDesc(array);
            SortedAsc = SortArrayAsc(array);
        }
        static int[] GetArrayFromConsole(int Num = 0)
        {
            Console.WriteLine("Введите количество чисел для сортировки: ");
            Num = int.Parse(Console.ReadLine());
            var result = new int[Num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArrayDesc(int[] arr1) // Сортировка по убыванию
        {
            int num;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        num = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = num;
                    }
                }
            }
            return arr1;
        }
        static int[] SortArrayAsc(int[] arr2) //Сортировка по возрастанию
        {
            int num;
            int[]arrAsc = new int[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        num = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = num;
                    }
                }

            }
            return arr2;
        }
    }
}

