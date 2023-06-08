using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TravelersBlog.Models;
using TravelersBlog.ViewModels;


namespace TravelersBlog.Controllers;

public class AccountsController : Controller
{
    private readonly ILogger<AccountsController> _logger;

    public AccountsController(ILogger<AccountsController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Register(RegisterViewModel user)
    {
      RegisterViewModel.Post(user);
      return RedirectToAction("Index");
    }
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Login(LoginViewModel user)
    {
      LoginViewModel.Post(user);
      return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}