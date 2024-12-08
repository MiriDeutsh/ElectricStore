﻿using Project.Core.Model;
using Project.Core.Repositories;

using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class ProductService: IProductService
    {
        private IProductRepository _ProductRepository;
        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        public List<Product> GetAllProduct()
        {
            return _ProductRepository.GetAll();

        }
        public Product GetProduct(int id)
        {
            return _ProductRepository.Get(id);
        }
        public Product PostProduct(Product product)
        {
            return _ProductRepository.Post(product);
        }
        public Product PutProduct(int id, Product product)
        {
            return _ProductRepository.Put(id, product);
        }
        public void DeleteOrder(int id)
        {
            _ProductRepository.Delete(id);
        }

    }
}
