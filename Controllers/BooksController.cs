using System.Web.Mvc;
using RepositoryPattern.Models.BooksLinq;

namespace RepositoryPattern.Controllers
{
    public class BooksController : Controller
    {
        private IBooksRepository _repository;


        /// <summary>
        /// This first parameterless constructor creates an instance of the
        /// BooksRepository class at runtime and passes it to the second constructor
        /// </summary>
        public BooksController()
            : this(new BooksRepository())
        {
        }

        /// <summary>
        /// Dependency Injection
        /// </summary>
        /// <param name="repository"></param>
        public BooksController(IBooksRepository repository)
        {
            _repository = repository;
        }


        public ActionResult Index()
        {
            return View(_repository.ListAll());
        }
    }
}
