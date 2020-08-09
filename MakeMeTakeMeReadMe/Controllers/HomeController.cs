using Microsoft.AspNetCore.Mvc;
using MakeMeTakeMeReadMe.Models;

namespace MakeMeTakeMeReadMe.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/readmeOneInput")]
    public ActionResult ReadmeOneInput() { return View(); }

    [Route("/readmeTwoInput")]
    public ActionResult ReadmeTwoInput() { return View(); }

    [Route("/readmeOneOutput")]
    public ActionResult ReadmeOneOutput(string text1)
    {
      Snippets readmeText = new Snippets();
      readmeText.AddText("text1", text1);
      return View(readmeText);
    }

    [Route("/readmeTwoOutput")]
    public ActionResult ReadmeTwoOutput(string text1)
    {
      Snippets readmeText = new Snippets();
      readmeText.AddText("text1", text1);
      return View(readmeText);
    }

  }
}
