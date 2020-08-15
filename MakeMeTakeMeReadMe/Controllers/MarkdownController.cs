using Microsoft.AspNetCore.Mvc;
using MakeMeTakeMeReadMe.Models;

namespace MakeMeTakeMeReadMe.Controllers
{
  public class MarkdownController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/readmeOneInput")]
    public ActionResult ReadmeOneInput() { return View(); }

    [Route("/readmeTwoInput")]
    public ActionResult ReadmeTwoInput() { return View(); }

    [Route("/readmeOneOutput")]
    public ActionResult ReadmeOneOutput(string title, string tagline, string about, string keyword1, string keyword2, string keyword3, string keyword4, string keyword5, string keyword6, string heroURL, string bugStatus, string bugDate, bool usesPhotoshop, bool usesVscode, bool usesMysql)
    {
      Markdown readmeText = new Markdown();
      readmeText.AddText("titleOpen", "**<h1 align = 'center'>");
      readmeText.AddText("title", title);
      readmeText.AddText("titleClose", "**");

      readmeText.AddText("taglineOpen", "*<h2 align ='center'>");
      readmeText.AddText("tagline", tagline);
      readmeText.AddText("taglineClose", "*");
      
      readmeText.AddText("heroOpen", "<h1 align='center'><img width='900' height='450' src='");
      readmeText.AddText("heroURL", heroURL);
      readmeText.AddText("heroClose", "'>" );

      readmeText.AddText("navigationBar", "<h3 align ='center'>•<a href='#requirements'>Requirements</a> •<a href='#setup'>Setup</a> •<a href='#protecting-your-data'>Protecting Data<a> •<a href='#questions-and-concerns'>Q's & C's</a> •<a href='#technologies-used'>Technologies</a> •<a href='#bugs'>Bugs</a> •<a href='#contributors'>Contributors</a>");
      
      readmeText.AddText("requirementSectionHeader", "## **REQUIREMENTS**");
      
      readmeText.AddText("setupSectionHeader", "## **SETUP**");
      readmeText.AddText("protectionSectionHeader", "## **PROTECTING YOUR DATA**");
      readmeText.AddText("technologiesSectionHeader", "## **Technologies Used**");

      readmeText.AddText("aboutOpen", "**<h3 align='center'>" );
      readmeText.AddText("about", about);
      readmeText.AddText("aboutClose", "</h3>**");
      
      readmeText.AddText("bugSectionHeader", "## **Known Bugs**");
      readmeText.AddText("bugStatus", bugStatus);
      readmeText.AddText("bugOpen", "_**" );
      readmeText.AddText("bugMiddle", " as of:** ");
      readmeText.AddText("bugDate", bugDate);
      readmeText.AddText("bugClose", "_");
    
      readmeText.AddText("contributorsSectionHeader", "## **❤️Contributors**");
      readmeText.AddText("contributorStartMarkdown", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/img/tristan_emmerson.jpg' width='160px;'/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br />");

      readmeText.AddText("keyword1", keyword1);
      readmeText.AddText("keyword2", keyword2);
      readmeText.AddText("keyword3", keyword3);
      readmeText.AddText("keyword4", keyword4);
      readmeText.AddText("keyword5", keyword5);
      readmeText.AddText("keyword6", keyword6);

      ViewBag.usesPhotoshop = usesPhotoshop;
      ViewBag.usesVscode = usesVscode;
      ViewBag.usesMysql = usesMysql;
      return View(readmeText);
    }
      
      
    }
    


  }

