using RegistrarTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RegistrarTracker.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarTrackerContext _db;
    public StudentsController(RegistrarTrackerContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Student> model = _db.Students
                            .ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      // ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      // if (student.CourseId == 0)
      // {
      //   return RedirectToAction("Create");
      // }
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}