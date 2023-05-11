using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ParamotorTurkey.Models;

namespace ParamotorTurkey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ParamotordbContext db = new ParamotordbContext();
    public IActionResult Index()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }

  [Route("/AboutUs")]
    public IActionResult AboutUs()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }

     [Route("/Blog")]
    public IActionResult Blog()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
     [Route("/Contact")]

    public IActionResult Contact()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
     [Route("/Elements")]

    public IActionResult Elements()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
     [Route("/Portfolio")]

     public IActionResult Portfolio()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
     [Route("/PortfolioDetails")]

     public IActionResult PortfolioDetails()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
     [Route("/Service")]

     public IActionResult Service()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
     [Route("/SingleBlog")]

     public IActionResult SingleBlog()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }

     [Route("/Event")]

     public IActionResult Event()
    {
         var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };

        return View(model);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
