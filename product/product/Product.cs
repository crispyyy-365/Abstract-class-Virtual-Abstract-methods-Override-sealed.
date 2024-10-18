using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class Product
    {

        private string _no;
        private string _name;
        private decimal _price;


        public string No
        {
            get { return _no; }
            set
            {
                if (_no.Length != 6)
                {
                    Console.WriteLine("nomre 6 reqemli deyil !");
                }
                _no = value;

            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price < 0)
                {
                    Console.WriteLine("duzgun qiymet verilmeyib");
                }
                _price = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Product(string no, string name, decimal price)
        {
            No = no;
            Name = name;
            Price = price;
        }
    }
}
