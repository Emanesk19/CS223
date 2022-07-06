using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class item
    {
        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public void save()
        {
            Console.WriteLine("Saved");
        }
    }
}
