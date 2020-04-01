using NormMVC.Abstract;
using NormMVC.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NormMVC
{
    public class ProductRepository : IProductRepository
    {
        private readonly NormMVCContext _dbContext;
        public ProductRepository(NormMVCContext context)
        {
            this._dbContext = context;
        }

        public List<Product> GetAll()
        {
            return _dbContext.Set<Product>().AsNoTracking().ToList();
        }

        public async Task<Product> GetById(int id)
        {
            // var result = await _dbContext.Set<Product>().FindAsync(id);
            var result = _dbContext.Set<Product>().AsNoTracking().Where(x => x.Id == id).Include(e => e.Category).ToList();

            return result.FirstOrDefault();
        }

        public void Insert(Product Entity)
        {
             _dbContext.Set<Product>().Add(Entity);
            _dbContext.SaveChanges();
        }
    }
}