using Business.Abstracts;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
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
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
            
        }

        public void Add(Product product)
        {
            if (product.Price == 0)
                throw new NotFoundException("Para yok.");
            else if (product.Price < 0)
            {
                throw new ValidationException(new List<ValidationExceptionModel>() { new ValidationExceptionModel() { Errors = new List<string> { "Price negatif değer alamaz!", "Price eksili olamaz!" }, Property = "Price" } });
                //throw new BusinessException("iş kazası");

            }

            else
            {
                _productRepository.Add(product);

            }
        }

        public async Task AddAsync(Product product)
        {
           await _productRepository.AddAsync(product);
        }


        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetList(p => p.Quantity > 0).ToList();
        }

        public Product? GetById(int id)
        {
            return _productRepository.Get(p => p.Quantity > 0);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
