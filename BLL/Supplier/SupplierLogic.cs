using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Supplier
{
    public class SupplierLogic
    {
        public Repository.Repository<Supplier> repository = new Repository.Repository<Supplier>();
        public void Save(Supplier supplier)
        {
            repository.Save("Suppliers", supplier);

        }

        public void Update(Supplier supplier)
        {
            repository.Edit("Suppliers", supplier, supplier.SupplierID);
        }


        public void Delete(int supplierID)
        {
            repository.Delete("Suppliers", supplierID);
        }
            
        public List<Supplier> GetSuppliers()
        {
            return repository.GetAll("Suppliers").ToList();
        }
    }
}
