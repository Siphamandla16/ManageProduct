using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Catergory
{
    public class CategoryLogic
    {
        public Repository.Repository<Catergory> repository = new Repository.Repository<Catergory>();
        public void Save(Catergory catergory)
        {
            repository.Save("Categories", catergory);
        }

        public void Update(Catergory catergory)
        {      
           repository.Edit("Categories", catergory,catergory.CategoryID);
        }


        public void Delete(int categoryID)
        {
            repository.Delete("Categories", categoryID);
        }

        public List<Catergory> GetCatergories()
        {          
            return repository.GetAll("Categories").ToList();
        }
    }
}
