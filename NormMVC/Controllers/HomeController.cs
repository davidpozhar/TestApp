using NormMVC.Abstract;
using NormMVC.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NormMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repository;
        private readonly NormMVCContext _context;

        public HomeController(IProductRepository repository, NormMVCContext context)
        {
            this._repository = repository;
            this._context = context;
        }

        public HomeController()
        {
            _repository = new ProductRepository(_context);
            _context = new NormMVCContext();
        }

        public ActionResult Index()
        {
            Product FirstProduct = new Product() { Id = 1, Name = "Mask", Price = 17, Description = "Lolol", FullDescription = "lolol1", CategoryId = 1, Category = new Category() { Id = 1, Name = "Coronavirus" } };
            return View(FirstProduct);
        }

        [Route("Home/GetById/{id?}")]
        public async Task<ActionResult> GetById(int Id)
        {
            try
            {
                Product model = await _repository.GetById(Id);
                return View(model);
            }
            catch
            {
                return HttpNotFound();
            }
        }
    }
}