using Business.Abstract;
using DataAccess.Cocrete.InMemory;
using Entities.Cocrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Cocrete
{
    public class ProductManager : IProductService
    {
        InMemoryProductDal _productDal;

        public ProductManager(InMemoryProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // is kodlari
            //Yetkisi var mı ?
            //Kurallar

            return _productDal.GetAll();
            
            
            
        }
    }
}
