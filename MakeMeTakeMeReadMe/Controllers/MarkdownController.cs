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
    public ActionResult ReadmeOneOutput(string title, string tagline, string about, string keyword1, string keyword2, string keyword3, string keyword4, string keyword5, string keyword6, string heroURL, string bugStatus, string bugDate, bool usesPhotoshop, bool usesVscode, bool usesMysql, bool hasAllisonSadin, bool hasBenWhite, bool hasBenRussell, bool hasBeverlyPotts, bool hasBrittanyLindgren, bool hasChristineAugustine, bool hasChrisYoon, bool hasCodyFritz, bool hasDeryckJackson, bool hasErichRichter, bool hasEvgeniyaChernaya, bool hasFrederickErnest, bool hasHannahBeinstein, bool hasIanGregg, bool hasIanScott, bool hasJamesHenager, bool hasJasonKhan, bool hasJeffreyKim, bool hasJohnNilsOlson, bool hasJosephPearce, bool hasKateSkorija, bool hasKevinDavis, bool hasKyleHubbard, bool hasMarielHamson, bool hasMeganHepner, bool hasMichealHansen, bool hasNoelKirkland, bool hasPeterGrimm, bool hasSaraKane, bool hasSeanDowns, bool hasSpencerMoody, bool hasTaylorPhillips, bool hasTaylorSomers, bool hasTeresaRosinksi, bool hasThomasGlenn, bool hasTristanEmmerson, bool hasTysonLackey, bool hasBugStatusNav, bool hasProtectingDataNav, bool hasCloningDataNav, bool usesJquery, bool usesWebpack, bool usesNodeJs, bool usesHtml, bool usesAspDotnetMvc, bool usesSwagger, bool usesBootstrap, bool usesCss, bool usesJavascript, bool usesCsharp)
    {
      Markdown readmeText = new Markdown();
      
      //hero image
      readmeText.AddText("heroOpen", "<h1 align='center'><img width='900' height='450' src='");
      readmeText.AddText("heroURL", heroURL);
      readmeText.AddText("heroClose", "'><br>" );

      //title markdown
      readmeText.AddText("titleOpen", "**<h1 align = 'center'>");
      readmeText.AddText("title", title);
      readmeText.AddText("titleClose", "**");
      
      //tagline
      readmeText.AddText("taglineOpen", "*<h2 align ='center'>");
      readmeText.AddText("tagline", tagline);
      readmeText.AddText("taglineClose", "*");

      //navigation
      readmeText.AddText("navigationBar", "<h3 align ='center'><a href='#requirements'>Requirements</a> •<a href='#setup'>Setup</a> •<a href='#technologies-used'>Technologies</a> •<a href='#❤️contributors'>Contributors</a>");
      readmeText.AddText("navClose", "</h3>");

      //about
      readmeText.AddText("aboutOpen", "<h3 align='center'>" );
      readmeText.AddText("about", about);
      readmeText.AddText("aboutClose", "</h3>");      
      
      //section headers
      readmeText.AddText("contributorsSectionHeader", "# **❤️Contributors**");
      readmeText.AddText("requirementSectionHeader", "# **REQUIREMENTS**");
      readmeText.AddText("technologiesSectionHeader", "# **TECHNOLOGIES USED**");
      
      //optional specifications section
      readmeText.AddText("specificationsSectionHeader", "# **SPECIFICATIONS**");
      readmeText.AddText("hasSpecificationDataNav", "•<a href='#specifications'>Specs</a>");
      
      //SETUP OVER-ARCHING PARENT HEADER//
      readmeText.AddText("setupSectionHeader", "# **SETUP**");

      //OPTIONAL: cloning section
      ViewBag.hasCloningDataNav = hasCloningDataNav;
      readmeText.AddText("hasCloningDataNav", "•<a href='#cloning'>Cloning</a>");
      readmeText.AddText("cloningSectionHeader", "## **CLONING**");
      readmeText.AddText("cloningTutorial1", "* Copy the repo link as shown in the image below");
      readmeText.AddText("cloningTutorial2", "![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif 'How to clone repo')");
      readmeText.AddText("cloningTutorial3", "* Paste the link in the field provided by VsCode as thown in the image below");
      readmeText.AddText("cloningTutorial4", "* You will be prompted to open the directory once you have cloned it. Select 'open'");
      readmeText.AddText("cloningTutorial5", "![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif 'Cloning from Github within VSCode')");

      //OPTIONAL: protecting data section
      ViewBag.hasProtectingDataNav = hasProtectingDataNav;
      readmeText.AddText("hasProtectingDataNav", "•<a href='#protecting-your-data'>Protecting Data</a>");
      readmeText.AddText("protectionSectionHeader", "## **PROTECTING YOUR DATA**");
      readmeText.AddText("protectionTutorial1", "* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.");
      readmeText.AddText("protectionTutorial2", "* Step 2: commit that .gitignore file (this prevents your sensitive information like your API key being shown to others). **DO NOT PROCEED UNTIL YOU DO THIS!**");
      readmeText.AddText("protectionTutorial3", "![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image-3.jpg 'Set up instructions')");

      //OPTIONAL: bug section
      ViewBag.hasBugStatusNav = hasBugStatusNav;
      readmeText.AddText("hasBugStatusNav", "•<a href='#known-bugs'>Bugs</a>");
      readmeText.AddText("bugSectionHeader", "## **KNOWN BUGS**");
      readmeText.AddText("bugStatus", bugStatus);
      readmeText.AddText("bugOpen", "_**" );
      readmeText.AddText("bugMiddle", " as of:** ");
      readmeText.AddText("bugDate", bugDate);
      readmeText.AddText("bugClose", "_");
      
      //OPTIONAL technologies used
      ViewBag.usesCss = usesCss;
      ViewBag.usesJavascript = usesJavascript;
      ViewBag.usesCsharp = usesCsharp;
      ViewBag.usesBootstrap = usesBootstrap;
      ViewBag.usesSwagger = usesSwagger;
      ViewBag.usesAspDotnetMvc = usesAspDotnetMvc;
      ViewBag.usesHtml = usesHtml;
      ViewBag.usesPhotoshop = usesPhotoshop;
      ViewBag.usesVscode = usesVscode;
      ViewBag.usesMysql = usesMysql;
      ViewBag.usesNodeJs = usesNodeJs;
      ViewBag.usesWebpack = usesWebpack;
      ViewBag.usesJquery = usesJquery;
      readmeText.AddText("usesPhotoshopSnippet", "_[Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_");
      readmeText.AddText("usesMysqlSnippet", "_[MySql Workbench](https://www.mysql.com/products/workbench/)_");
      readmeText.AddText("usesVscodeSnippet", "_[Visual Studio Code](https://code.visualstudio.com/)_");
      readmeText.AddText("usesCssSnippet", "_[CSS](https://en.wikipedia.org/wiki/Cascading_Style_Sheets)_");
      readmeText.AddText("usesJavascriptSnippet", "_[Javascript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)_");
      readmeText.AddText("usesCsharpSnippet", "_[C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_");
      readmeText.AddText("usesBootstrapSnippet", "_[Bootstrap](https://getbootstrap.com/)_");
      readmeText.AddText("usesSwaggerSnippet", "_[Swagger](https://swagger.io/)_");
      readmeText.AddText("usesAspDotnetMvcSnippet", "_[Asp.Net MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)_");
      readmeText.AddText("usesHtmlSnippet", "_[HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)_");
      readmeText.AddText("usesNodeJsSnippet", "_[Node.js](https://nodejs.org/en/)_");
      readmeText.AddText("usesWebpackSnippet", "_[Webpack](https://webpack.js.org/)_");
      readmeText.AddText("usesJquerySnippet", "_[Jquery](https://jquery.com/)_");

      //contributors
      readmeText.AddText("contributorAllisonSadin", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/allison-sadin.jpeg' width='160px;'/><br /><sub><b>Allison Sadin</b></sub>](https://www.linkedin.com/in/allison-sadin-pdx/)<br />");
      readmeText.AddText("contributorBenWhite", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/ben-white.jpeg' width='160px;'/><br /><sub><b>Ben White</b></sub>](https://www.linkedin.com/in/ben-m-white/)<br />");
      readmeText.AddText("contributorBenRussell", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/ben-russell.jpeg' width='160px;'/><br /><sub><b>Ben Russell</b></sub>](https://www.linkedin.com/in/ben-russell36/)<br />");
      readmeText.AddText("contributorBeverlyPotts", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/beverly-potts.jpeg' width='160px;'/><br /><sub><b>Beverly Potts</b></sub>](https://www.linkedin.com/in/beverlypotts/)<br />");
      readmeText.AddText("contributorBrittanyLindgren", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/brittany-lindgren.jpeg' width='160px;'/><br /><sub><b>Brittany Lindgren</b></sub>](https://www.linkedin.com/in/brittanylindgren/)<br />");
      readmeText.AddText("contributorChristineAugustine", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/christine-augustine.jpeg' width='160px;'/><br /><sub><b>Christine Augustine</b></sub>](https://www.linkedin.com/in/christineaugustine/)<br />");
      readmeText.AddText("contributorChrisYoon", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/chris-yoon.jpeg' width='160px;'/><br /><sub><b>Chris Yoon</b></sub>](https://www.linkedin.com/in/chris-yoon-302b8254/)<br />");
      readmeText.AddText("contributorCodyFritz", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/cody-fritz.jpeg' width='160px;'/><br /><sub><b>Cody Fritz</b></sub>](https://www.linkedin.com/in/zentraxius/)<br />");
      readmeText.AddText("contributorDeryckJackson", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/deryck-jackson.jpeg' width='160px;'/><br /><sub><b>Deryck Jackson</b></sub>](https://www.linkedin.com/in/deryckjackson/)<br />");
      readmeText.AddText("contributorErichRichter", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/erich-richter.jpeg' width='160px;'/><br /><sub><b>Erich Richter</b></sub>](https://www.linkedin.com/in/erichjrichter/)<br />");
      readmeText.AddText("contributorEvgeniyaChernaya", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/evgeniya-chernaya.jpeg' width='160px;'/><br /><sub><b>Evgeniya Chernaya</b></sub>](https://www.linkedin.com/in/evgeniyach/)<br />");
      readmeText.AddText("contributorFrederickErnest", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/frederick-ernest.jpeg' width='160px;'/><br /><sub><b>Frederick Ernest</b></sub>](https://www.linkedin.com/in/frederick-ernest/)<br />");
      readmeText.AddText("contributorHannahBeinstein", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/hannah-beinstein.jpeg' width='160px;'/><br /><sub><b>Hannah Beinstein</b></sub>](https://www.linkedin.com/in/hannahbeinstein/)<br />");
      readmeText.AddText("contributorIanGregg", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/ian-gregg.jpeg' width='160px;'/><br /><sub><b>Ian Gregg</b></sub>](https://www.linkedin.com/in/iandgregg/)<br />");
      readmeText.AddText("contributorIanScott", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/ian-scott.jpeg' width='160px;'/><br /><sub><b>Ian Scott</b></sub>](https://www.linkedin.com/in/ian-scott-portland-or/)<br />");
      readmeText.AddText("contributorJamesHenager", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/james-henager.jpeg' width='160px;'/><br /><sub><b>James Henager</b></sub>](https://www.linkedin.com/in/james-henager/)<br />");
      readmeText.AddText("contributorJasonKhan", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/jason-khan.jpeg' width='160px;'/><br /><sub><b>Jason Khan</b></sub>](https://www.linkedin.com/in/jasonkhan99/)<br />");
      readmeText.AddText("contributorJeffreyKim", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/jeffrey-kim.jpeg' width='160px;'/><br /><sub><b>Jeffrey Kim</b></sub>](https://www.linkedin.com/in/jeffrey-kim-0122/)<br />");
      readmeText.AddText("contributorJohnNilsOlson", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/johnnils-olson.jpeg' width='160px;'/><br /><sub><b>JohnNils Olson</b></sub>](https://www.linkedin.com/in/johnnilsolson/)<br />");
      readmeText.AddText("contributorJosephPearce", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/joseph-pearce.jpeg' width='160px;'/><br /><sub><b>Joseph Pearce</b></sub>](https://www.linkedin.com/in/pjosephpearce/)<br />");
      readmeText.AddText("contributorKateSkorija", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/kate-skorija.jpeg' width='160px;'/><br /><sub><b>Kate Skorija</b></sub>](https://www.linkedin.com/in/kate-skorija/)<br />");
      readmeText.AddText("contributorKevinDavis", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/kevin-davis.jpeg' width='160px;'/><br /><sub><b>Kevin Davis</b></sub>](https://www.linkedin.com/in/kevinrobertdavis/)<br />");
      readmeText.AddText("contributorKyleHubbard", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/kyle-hubbard.jpeg' width='160px;'/><br /><sub><b>Kyle Hubbard</b></sub>](https://www.linkedin.com/in/k-j-hubbard/)<br />");
      readmeText.AddText("contributorMarielHamson", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/mariel-hamson.jpeg' width='160px;'/><br /><sub><b>Mariel Hamson</b></sub>](https://www.linkedin.com/in/marielhamson/)<br />");
      readmeText.AddText("contributorMeganHepner", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/megan-hepner.jpeg' width='160px;'/><br /><sub><b>Megan Hepner</b></sub>](https://www.linkedin.com/in/meganhepnerportland/)<br />");
      readmeText.AddText("contributorMichealHansen", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/micheal-hansen.jpeg' width='160px;'/><br /><sub><b>Micheal Hansen</b></sub>](https://www.linkedin.com/in/michealhansen/)<br />");
      readmeText.AddText("contributorNoelKirkland", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/noel-kirkland.jpeg' width='160px;'/><br /><sub><b>Noel Kirkland</b></sub>](https://www.linkedin.com/in/noel-kirkland/)<br />");
      readmeText.AddText("contributorPeterGrimm", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/peter-grimm.jpeg' width='160px;'/><br /><sub><b>Peter Grimm</b></sub>](https://www.linkedin.com/in/pagrimm/)<br />");
      readmeText.AddText("contributorSaraKane", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/sara-kane.jpeg' width='160px;'/><br /><sub><b>Sara Kane</b></sub>](https://www.linkedin.com/in/sarakaneportland/)<br />");
      readmeText.AddText("contributorSeanDowns", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/sean-downs.jpeg' width='160px;'/><br /><sub><b>Sean Downs</b></sub>](https://www.linkedin.com/in/sean-downs/)<br />");
      readmeText.AddText("contributorSpencerMoody", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/spencer-moody.jpeg' width='160px;'/><br /><sub><b>Spencer Moody</b></sub>](https://www.linkedin.com/in/spenceramoody/)<br />");
      readmeText.AddText("contributorTaylorPhillips", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/taylor-phillips.jpeg' width='160px;'/><br /><sub><b>Taylor Phillips</b></sub>](https://www.linkedin.com/in/taylorphillipsportland/)<br />");
      readmeText.AddText("contributorTaylorSomers", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/taylor-somers.jpeg' width='160px;'/><br /><sub><b>Taylor Somers</b></sub>](https://www.linkedin.com/in/taylorsomers/)<br />");
      readmeText.AddText("contributorTeresaRosinksi", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/teresa-rosinksi.jpeg' width='160px;'/><br /><sub><b>Teresa Rosinksi</b></sub>](https://www.linkedin.com/in/teresarosinski/)<br />");
      readmeText.AddText("contributorThomasGlenn", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/thomas-glenn.jpeg' width='160px;'/><br /><sub><b>Thomas Glenn</b></sub>](https://www.linkedin.com/in/glennergy/)<br />");
      readmeText.AddText("contributorTristanEmmerson", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/tristan-emmerson.jpeg' width='160px;'/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br />");
      readmeText.AddText("contributorTysonLackey", "| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/tyson-lackey.jpeg' width='160px;'/><br /><sub><b>Tyson Lackey</b></sub>](https://www.linkedin.com/in/tyson-lackey/)<br />");

      //contributors
      ViewBag.hasAllisonSadin = hasAllisonSadin;
      ViewBag.hasBenWhite = hasBenWhite;
      ViewBag.hasBenRussell = hasBenRussell;
      ViewBag.hasBeverlyPotts = hasBeverlyPotts;
      ViewBag.hasBrittanyLindgren = hasBrittanyLindgren;
      ViewBag.hasChristineAugustine = hasChristineAugustine;
      ViewBag.hasChrisYoon = hasChrisYoon;
      ViewBag.hasCodyFritz = hasCodyFritz;
      ViewBag.hasDeryckJackson = hasDeryckJackson;
      ViewBag.hasErichRichter = hasErichRichter;
      ViewBag.hasEvgeniyaChernaya = hasEvgeniyaChernaya;
      ViewBag.hasFrederickErnest = hasFrederickErnest;
      ViewBag.hasHannahBeinstein = hasHannahBeinstein;
      ViewBag.hasIanGregg = hasIanGregg;
      ViewBag.hasIanScott = hasIanScott;
      ViewBag.hasJamesHenager = hasJamesHenager;
      ViewBag.hasJasonKhan = hasJasonKhan;
      ViewBag.hasJeffreyKim = hasJeffreyKim;
      ViewBag.hasJohnNilsOlson = hasJohnNilsOlson;
      ViewBag.hasJosephPearce = hasJosephPearce;
      ViewBag.hasKateSkorija = hasKateSkorija;
      ViewBag.hasKevinDavis = hasKevinDavis;
      ViewBag.hasKyleHubbard = hasKyleHubbard;
      ViewBag.hasMarielHamson = hasMarielHamson;
      ViewBag.hasMeganHepner = hasMeganHepner;
      ViewBag.hasMichealHansen = hasMichealHansen;
      ViewBag.hasNoelKirkland = hasNoelKirkland;
      ViewBag.hasPeterGrimm = hasPeterGrimm;
      ViewBag.hasSaraKane = hasSaraKane;
      ViewBag.hasSeanDowns = hasSeanDowns;
      ViewBag.hasSpencerMoody = hasSpencerMoody;
      ViewBag.hasTaylorPhillips = hasTaylorPhillips;
      ViewBag.hasTaylorSomers = hasTaylorSomers;
      ViewBag.hasTeresaRosinksi = hasTeresaRosinksi;
      ViewBag.hasThomasGlenn = hasThomasGlenn;
      ViewBag.hasTristanEmmerson = hasTristanEmmerson;
      ViewBag.hasTysonLackey = hasTysonLackey;
      
      //keywords
      readmeText.AddText("keyword1", keyword1);
      readmeText.AddText("keyword2", keyword2);
      readmeText.AddText("keyword3", keyword3);
      readmeText.AddText("keyword4", keyword4);
      readmeText.AddText("keyword5", keyword5);
      readmeText.AddText("keyword6", keyword6);

      //license
      readmeText.AddText("mitHeader", "## **License**");
      readmeText.AddText("mitLicense1", "![alt text][logo]");
      readmeText.AddText("mitLicense2", "[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'");

      return View(readmeText);
    }
    }

  }

