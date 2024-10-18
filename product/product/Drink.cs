using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class Drink : Product
    {
        private int _alcoholPercent;

        public int AlcoholPercent
        {
            get { return _alcoholPercent; }
            set
            {
                if (_alcoholPercent > 100 || _alcoholPercent < 0)
                {
                    Console.WriteLine("Faiz duzgun verilmeyib");
                }
                _alcoholPercent = value;
            }
        }
        public Drink(string no, string name, decimal price, int alcoholPercent) : base(no, name, price)
        {
            AlcoholPercent = alcoholPercent;
        }
    }
}
