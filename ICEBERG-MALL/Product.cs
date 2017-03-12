using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG_MALL
{
    class Product
    {
        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private string _nameProduct;

        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; }
        }

        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public Product(string category, string nameProduct, int price, string country)
        {
            _category = category;
            _nameProduct = nameProduct;
            _price = price;
            _country = country;
        }

    }
}
