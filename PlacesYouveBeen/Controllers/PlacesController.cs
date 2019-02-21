using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")] 
    public ActionResult Index() //load up this html with when this path is loaded with allPlaces, invoking commands in the controller. controller is a controller where you can invoke methods when a path is loaded or invoke variables
    {
      List<Place> allPlaces = Place.GetAll(); // calling the get all method for all the places
      return View(allPlaces); // look more into this... Return the list of all the items
    }

    [HttpGet("/places/new")]
    public ActionResult PlacesForm()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName) // passing in the string description through form
    {
      Place myPlace = new Place(cityName);
      return RedirectToAction("Index");                     //The RedirectToAction() method, seen above, tells .NET to rerun whatever route method is provided as an argument
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
  }
}