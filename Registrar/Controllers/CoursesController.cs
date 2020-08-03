using Registrar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Registrar.Controllers
{
  public class CoursesController : Controller
  {
    private readonly RegistrarContext _db;
    public CoursesController(RegistrarContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Courses.ToList());
    }
  }
}