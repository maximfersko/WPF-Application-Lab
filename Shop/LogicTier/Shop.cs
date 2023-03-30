using DataTier;


namespace LogicTier
{
    public class Shop
    {
        private List<ProductPosition> _products = new List<ProductPosition>();

        public Shop()
        {
            List<Product> tmp = AllProducts.GetAllProducts();
            foreach(var t in tmp)
            {
                _products.Add(new ProductPosition(t));
            }
        }

        public List<ProductPosition> ListProducts
        {
            get { return _products; }
        }

        public string NameShop
        {
            get { return "Our Shop"; }
        }

        public float TotalPrice
        {
            get
            {
                return _products.Sum(p => p.TotalPricePosition);
            }
        }

        public float TotalProducts
        {
            get
            {
                return _products.Sum(p => p.QuantityProducts);
            }
        }
    }
}
