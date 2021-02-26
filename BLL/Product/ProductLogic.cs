using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Product
{
    public class ProductLogic
    {
        public Repository.Repository<Product> repository = new Repository.Repository<Product>();
        public void Save(Product product)
        {
            repository.Save("Products", product);
        }

        public void Update(Product product)
        {
            repository.Edit("Products", product, product.CategoryID);
        }


        public void Delete(int productsID)
        {
            repository.Delete("Products", productsID);
        }

        public List<Product> GetProducts()
        {
            return repository.GetAll("Products").ToList();
        }
    }
}
