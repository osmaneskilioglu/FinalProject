using DataAccess.Abstarct;
using Entities.Cocrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Cocrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
            
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnintInStok =15, UnitPrice= 15},
                new Product{ProductId=1, CategoryId=1, ProductName="Kamera", UnintInStok =3, UnitPrice= 500},
                new Product{ProductId=1, CategoryId=2, ProductName="Telefon", UnintInStok =2, UnitPrice= 1500},
                new Product{ProductId=1, CategoryId=1, ProductName="Klavye", UnintInStok =65, UnitPrice= 150},
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnintInStok =1, UnitPrice= 85},

            };

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //Lambda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);             

            _products.Remove(productToDelete);
                       
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ID sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnintInStok = product.UnintInStok;



            _products.Remove(productToUpdate);
        }

        public List<Product> GetAllByCategry(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
