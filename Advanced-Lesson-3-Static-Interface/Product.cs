using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public class Product
    {
        static int ID { get; set; }
        public int ProductId { get; private set; }
        public string Name { get; set; }

        static Product()
        {
            ID = new Random().Next(1000);
        }

        public Product(string name)
        {
            ProductId = ID++;
            
            Name = name;
        }

        

    }
}
