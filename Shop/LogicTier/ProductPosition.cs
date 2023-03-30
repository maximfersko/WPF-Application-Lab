using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTier
{
     public class ProductPosition
    {
        private Product _product;

        public ProductPosition(Product p)
        {
            _product = p;
        }

        public string CodeProducts
        {
            get { return _product.Code; }
            set { _product.Code = value; }
        }

        public string NameProducts
        {
            get { return _product.Name; }
            set { _product.Name = value; }
        }

        public float PriceProducts
        {
            get { return _product.Price; }
            set { _product.Price = value; }
        }

        public int QuantityProducts
        {
            get { return _product.Quantity; }
            set { _product.Quantity = value; }
        }

        public string DescriptionProducts
        {
            get { return _product.Description; }
            set { _product.Description = value; }
        }

        public float TotalPricePosition
        {
            get { return _product.Price * _product.Quantity; }
        }

        public string ListProducts
        {
            get {
                return _product.Code + " : " + _product.Name +
                    " ( " + _product.Price.ToString("C") + ")";
            }

        }
    }
}
