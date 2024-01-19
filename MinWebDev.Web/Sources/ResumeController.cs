using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MinWebDev.Web;

public class ResumeController : Controller
{
    [Route("")]
    [HttpGet]
    public IActionResult Index()
    {
        return this.View("~/Sources/Resume.cshtml");
    }
}
