/*using Microsoft.AspNetCore.Mvc;
using SurveyForm.Data;
using SurveyForm.Models.DbEntities;

namespace SurveyForm.Controllers
{
    public class PeopleController : Controller
    {
        private readonly MyDbContext _context;

        public PeopleController(MyDbContext context)
        {
            _context = context;
        }

        // GET: People/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {
                _context.people.Add(people);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(people);
        }
    }
}
*/