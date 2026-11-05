using Microsoft.AspNetCore.Mvc;
using MYAcademy_PortfolioProject.Context;
using Microsoft.EntityFrameworkCore;

namespace MYAcademy_PortfolioProject.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly PortfolioContext _context;

        public ProjectController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ProjectList()
        {
            var values = _context.Projects.Include(x => x.Category).ToList();
            return View(values);
        }
    }
}
