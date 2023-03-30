

namespace DataTier
{
    public class AllProducts 
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product()
            {
                Code = "001",
                Name = "OC Windows 8",
                Quantity = 10,
                Price = 40.99f,
                Description = "Modern operating system. Version 8"
            });

            list.Add(new Product()
            {
                Code = "002",
                Name = "3D Max",
                Quantity = 2,
                Price = 500.99f,
                Description = "Visualization and rendering system from Autodesk corp"
            });

            list.Add(new Product()
            {
                Code = "003",
                Name = "Total commander 1.0",
                Quantity = 100,
                Price = 0.5f,
                Description = "-"
            });

            list.Add(new Product()
            {
                Code = "004-001",
                Name = "MS SQL Server",
                Quantity = 5,
                Price = 150.00f,
                Description = "SUBD from Microsoft Corp."
            });
            return list;
        }

        public static void SaveAllProducts()
        {

        }
    }
}