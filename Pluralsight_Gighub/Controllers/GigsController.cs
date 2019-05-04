using Pluralsight_Gighub.Models;
using Pluralsight_Gighub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Pluralsight_Gighub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}