using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class Store
    {
        private int _dairyProductionCountLimit;
        private int _alcoholPercentLimit;

        Product[] _products = new Product[0];
        public int DairyProductionCountLimit
        {
            get { return _dairyProductionCountLimit; }
            set { _dairyProductionCountLimit = value; }
        }
        public int AlcoholPercentLimit
        {
            get { return _alcoholPercentLimit; }
            set
            {
                if (AlcoholPercentLimit > 100 || AlcoholPercentLimit < 0)
                    Console.WriteLine("faiz duzgun verilmeyib");

                _alcoholPercentLimit = value;
            }

        }
        public Store(int dairyProductionCountLimit, int alcoholPercentLimit)
        {
            AlcoholPercentLimit = alcoholPercentLimit;
            DairyProductionCountLimit = dairyProductionCountLimit;
        }
        public void AddProduct(Product product, Product[] _products)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }
        public bool HasProductByNo(string no)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (no == _products[i].No)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
