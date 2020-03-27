using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

//new using directives
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Treats.Controllers
{
  [Authorize] //new line
  public class FlavorsController : Controller
  {
    private readonly TreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager; //new line

    //updated constructor
    public FlavorsController(UserManager<ApplicationUser> userManager, TreatContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    //updated Index method
    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userFlavors = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id);
      return View(userFlavors);
    }

    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View();
    }

    //updated Create post method
    [HttpPost]
    public async Task<ActionResult> Create(Flavor Flavor, int TreatId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      Flavor.User = currentUser;
      _db.Flavors.Add(Flavor);
      if (TreatId != 0)
      {
        _db.TreatsFlavor.Add(new TreatsFlavor() { TreatId = TreatId, FlavorId = Flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
          .Include(Flavor => Flavor.Treats)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(Flavor => Flavor.FlavorId == id);
      return View(thisFlavor);
    }

    public ActionResult Edit(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor Flavor, int TreatId)
    {
      if (TreatId != 0)
      {
        _db.TreatsFlavor.Add(new TreatsFlavor() { TreatId = TreatId, FlavorId = Flavor.FlavorId });
      }
      _db.Entry(Flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult AddTreat(Flavor Flavor, int TreatId)
    {
      if (TreatId != 0)
      {
        _db.TreatsFlavor.Add(new TreatsFlavor() { TreatId = TreatId, FlavorId = Flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTreat(int joinId)
    {
      var joinEntry = _db.TreatsFlavor.FirstOrDefault(entry => entry.TreatsFlavorId == joinId);
      _db.TreatsFlavor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}