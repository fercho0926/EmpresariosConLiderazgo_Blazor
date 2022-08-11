using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpresariosBlazor.Data.Product
{
    public interface IProductService
    {
        Task<IEnumerable<Models.Product>> GetAll();

        Task<bool> SaveProduct(Models.Product product);
    }
}