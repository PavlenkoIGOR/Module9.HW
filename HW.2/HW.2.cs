using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9_HW_2
{
    class ForEvent
    {
        public delegate void NumberEnteredDelegate(int number, string[] names);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read()
        {
        link1:
            Console.Write(Environment.NewLine + "Выберете тип сортировки:" + Environment.NewLine + "А-Я (нажмите 1) или Я-А (нажмите 2): ");
            byte choice = default;
            try
            {
                choice = Convert.ToByte(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    Console.WriteLine("Выбран метод ''Сортировка А-Я''");
                    break;

                    case 2:
                    Console.WriteLine("Выбран метод ''Сортировка Я-А''");
                    break;

                    default:
                    throw new Exception("неверный выбор");
                }
            }
            catch (Exception ex) when (ex.Message == "неверный выбор")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ну ппц! {choice}? Cерьёзно?! 1 или 2!");
                Console.ForegroundColor = ConsoleColor.White;
                goto link1;
            }
            catch (Exception oops)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ёлки... {oops.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                goto link1;
            }
            NumberEntered(choice, names);
        }
        public string[] names;
        protected virtual void NumberEntered(int number, string[] names) //данный метод будет вызывать событие NumberEnteredEvent
        {
            NumberEnteredEvent?.Invoke(number, names);
        }

    }
    internal class HW2
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Иванов", "Сидоров", "Петров", "Убейконь", "Вагин", "Ягодицин", "Сухозадов", "Козюлин", "Сволочёв" };

            ForEvent fE = new ForEvent();
            fE.names = arr;
            Console.Write("Массив имён: ");
            foreach (var name in arr)
            {
                Console.Write(name + " ");
            }
            fE.NumberEnteredEvent += NamesForSort;
            fE.Read();

            Console.ReadKey();
        }


        static void NamesForSort(int choice, string[] names)
        {


            switch (choice)
            {
                case 1:
                Console.WriteLine($"Введено {choice}");
                SortMaxMin(names);
                break;
                case 2:
                Console.WriteLine($"Введено {choice}");
                SortMaxMin(names);
                break;
            }
        }
        public static void SortMinMax(string[] array)
        {
            Array.Sort(array);
            foreach (string str in array)
            {
                Console.Write(str + " ");
            }
        }

        public static void SortMaxMin(string[] array)
        {
            IEnumerable<string> query = from word in array
                                        orderby word.Substring(0, 1) descending
                                        select word;

            foreach (string str in query)
            {
                Console.Write(str + " ");
            }
        }
    }
}

