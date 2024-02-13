using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SurveyForm.Data;
using SurveyForm.Models;
using SurveyForm.Models.DbEntities;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SurveyForm.Controllers
{
    public class DropDownController : Controller
    {
        private readonly MyDbContext _context;

        public DropDownController(MyDbContext context)
        {
            _context = context;
        }


        public IActionResult Create()
        {
            var states=_context.state.ToList();
            ViewBag.state = new SelectList(states, "StateName", "StateName"); 
            return View(new People());
        }


        [HttpPost]
        public IActionResult Create(People model)
        {
            if (ModelState.IsValid)
            {
              /*var Sname= person.State;
                var Cname = person.City;*/
                _context.people.Add(model);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Person created successfully";
                return RedirectToAction("Create");
            }
            var states=_context.state.ToList();
            ViewBag.state = new SelectList(states,"StateName","StateName",model.State);
            return View(model);
        }

        public IActionResult Display() { 
            
            var peopledata= _context.people.ToList();
            return View(peopledata); }

        public JsonResult GetCities(string stateName)
        {
            var state=_context.state.Include(s=>s.Cities).FirstOrDefault(s=>s.StateName==stateName);

            var cities = state?.Cities.Select(
                c => new { 
                CityName=c.Name
                }
                
                );
            return Json(cities);
        }
    }
}
