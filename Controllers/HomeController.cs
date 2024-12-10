using Microsoft.AspNetCore.Mvc;
using SonarLintIssueSample.Models;
using System.Diagnostics;

namespace SonarLintIssueSample.Controllers;

public class HomeController : Controller
{
    private const string RememberedRoleAutoSelect = "rras";
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [ModelStateValidation]
    public IActionResult Index()
    {
        _ = GetRemeberdRoleSelection();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Post()
    {
        Microsoft.Extensions.Primitives.StringValues name = Request.Form["name"];                           // Noncompliant: Request.Form
        Microsoft.Extensions.Primitives.StringValues birthdate = Request.Form["Birthdate"]; // Noncompliant: Request.Form
        string locale = Request.Query.TryGetValue("locale", out Microsoft.Extensions.Primitives.StringValues locales)
            ? locales.ToString()
            : "en-US";                                             // Noncompliant: Request.Query
        return Ok();
    }

    private Guid? GetRemeberdRoleSelection()
    {
        if (!HttpContext.Request.Query[RememberedRoleAutoSelect].Equals(Boolean.TrueString))
        {
            return null;
        }

        return null;
    }
}
