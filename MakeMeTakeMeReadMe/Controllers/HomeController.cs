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
    public ActionResult ReadmeOneOutput(string title, string tagline, string about, string keyword1, string keyword2, string keyword3, string keyword4, string keyword5, string keyword6)
    {
      Snippets readmeText = new Snippets();
      readmeText.AddText("title", title);
      readmeText.AddText("tagline", tagline);
      readmeText.AddText("about", about);
      readmeText.AddText("keyword1", keyword1);
      readmeText.AddText("keyword2", keyword2);
      readmeText.AddText("keyword3", keyword3);
      readmeText.AddText("keyword4", keyword4);
      readmeText.AddText("keyword5", keyword5);
      readmeText.AddText("keyword6", keyword6);
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
