using NormMVC.Models;
using System.Threading.Tasks;

namespace NormMVC.Abstract
{
    public interface IProductRepository
    {
        Task<Product> GetById(int id);
    }
}
