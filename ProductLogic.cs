using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class ProductLogic
    {
        List<Product> _products;
        Dictionary<string, DogLeash> _leashes;
        Dictionary<string, CatFood> _food;

        public ProductLogic()
        {
            _products = new List<Product>();
            _leashes = new Dictionary<string, DogLeash>();
            _food = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("Parameter 'product' cannot be null");
            _products.Add(product);
            if (product is DogLeash) _leashes.Add(product.Name, product as DogLeash);
            if (product is CatFood) _food.Add(product.Name, product as CatFood);
        }

        public List<Product> GetAllProducts() { return _products; }

        public DogLeash? GetDogLeashByName(string name)
        {
            try
            {
                return _leashes[name];
            }
            catch (KeyNotFoundException ex)
            {
                return null;
            }

        }
    }
}
