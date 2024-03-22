using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        List<Product> products;

        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int id)
        {
            products.Remove(products.Find(x=> x.Id == id));
        }

        public List<Product> GetAll()
        {
            return this.products;
        }

        public Product GetById(int id)
        {
            return products.Find(x => x.Id == id);
        }

        public void Update(Product product)
        {
            Product foundProduct = products.Find(x => x.Id == product.Id);
            foundProduct.Name = product.Name;
            foundProduct.UnitPrice = product.UnitPrice;
        }
    }
}
