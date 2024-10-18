using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class Dairy : Product
    {
        private int _fatPercent;

        public int FatPercent
        {
            get { return _fatPercent; }
            set
            {
                if (_fatPercent > 100 || _fatPercent < 0)
                {
                    Console.WriteLine("Faiz dugun verilmeyib");
                }
                _fatPercent = value;
            }
        }
        public Dairy(string no, string name, decimal price, int fatPercent) : base(no, name, price)
        {
            FatPercent = fatPercent;
        }
    }
}
