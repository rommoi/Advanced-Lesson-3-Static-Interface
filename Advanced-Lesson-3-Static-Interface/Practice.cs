using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
            
            List<Product> pList = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                pList.Add(new Product("++" + DateTime.Now + ";;"));
            }
            foreach (var item in pList)
            {
                Console.WriteLine($"{item.Name,-10} \t {item.ProductId}");
            }
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
            Console.WriteLine("string:");
            GuessType("abcdefghjklmnopqrstuvwxyz");
            Console.WriteLine("UInt:");
            GuessType((uint)123456);
            Console.WriteLine("Int");
            GuessType(123456);
            Console.WriteLine("Double:");
            GuessType(123456.7890);
            Console.WriteLine("Double 1/int");
            GuessType((double)(1.0 / 3.0));
            Console.WriteLine("Decimal 1/long");
            GuessType((decimal)(1.0 / long.MaxValue));
            Console.WriteLine("DateTime:");
            GuessType(DateTime.Now);
            Console.WriteLine("Object:");
            GuessType((object)6);
            Console.WriteLine();
        }


        private static void GuessType<T>(T item)
        {
            switch (item)
            {
                case string str:
                    Console.WriteLine($"You entered string that contains {str.Length} symbols.");
                    break;
                case uint val:
                    Console.WriteLine("You entered positive integer.");
                    break;
                case double dVal:
                    Console.WriteLine($"You entered float with {dVal.ToString().Length} digits : {dVal}"); 
                    break;
                case DateTime dt:
                    Console.WriteLine($"You entered time {dt.ToString()}");
                    break;
                case decimal dc:
                    Console.WriteLine($"You entered decimal {dc} with {dc.ToString().Length} digits");
                    break;
                //case object obj:
                //    Console.WriteLine($"You entered some object.");
                //    break;
                default:
                    Console.WriteLine("I don't know what is this...");
                    break;
            }
        }
    }    
}
