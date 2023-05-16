using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDelivery
{
    class FoodProvider
    {
        Product _product;
        string _name;
        double _distance;
        ConcurrentQueue<int> cooker;
        string _openingTime;
        string _closingTime;
        List<Product> listProducts;
        List<Product> listCookProducts;

        internal FoodProvider(string Name, double Distance, string OpeningTime, string ClosingTime)
        {
            listProducts = new List<Product>();
            listCookProducts = new List<Product>();
            cooker = new ConcurrentQueue<int>();

            _name = Name;
            _distance = Distance;
            _openingTime = OpeningTime;
            _closingTime = ClosingTime;
        }

        internal void AddProduct(int Id, string Name, double PreparationTime, decimal Price)
        {
            _product = new Product(Id, Name, PreparationTime, Price);
            listProducts.Add(_product);
        }

        internal void Order(string productName)
        {
            var result = searchProduct(productName);

        }
        private Product searchProduct(string product)
        {
            var result = listProducts.Find(item => item.Name.Equals(product));
            return result;
        }

        internal void CookProduct(Product product)
        {
        }


        #region classeProdotto
        class Product
        {
            int _id;
            string _name;
            double _preparationTime;
            decimal _price;

            public string Name { get => _name; set => _name = value; }

            internal Product(int Id, string Name, double PreparationTime, decimal Price)
            {
                _id = Id;
                this.Name = Name;
                _preparationTime = PreparationTime;
                _price = Price;
            }
        }
        #endregion
    }
   
}
