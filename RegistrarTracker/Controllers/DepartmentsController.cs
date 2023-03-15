using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RegistrarTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistrarTracker.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly RegistrarTrackerContext _db;

    public DepartmentsController(RegistrarTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Department> model = _db.Departments.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Department thisDepartment = _db.Departments
                                .Include(department => department.Students)
                                .ThenInclude(item => item.JoinEntities)
                                .ThenInclude(join => join.Course)
                                .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }
  }
}