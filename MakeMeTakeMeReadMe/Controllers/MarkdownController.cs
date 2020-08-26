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

    [Route("/readmeOneOutput")]
    public ActionResult ReadmeOneOutput(string title, string tagline, string about, string keyword1, string keyword2, string keyword3, string keyword4, string keyword5, string keyword6, string heroURL, string bugStatus, string bugDate, bool usesPhotoshop, bool usesVscode, bool usesMysql, bool hasAllisonSadin, bool hasBenWhite, bool hasBenRussell, bool hasBeverlyPotts, bool hasBrittanyLindgren, bool hasChristineAugustine, bool hasChrisYoon, bool hasCodyFritz, bool hasDeryckJackson, bool hasErichRichter, bool hasEvgeniyaChernaya, bool hasFrederickErnest, bool hasHannahBeinstein, bool hasIanGregg, bool hasIanScott, bool hasJamesHenager, bool hasJasonKhan, bool hasJeffreyKim, bool hasJohnNilsOlson, bool hasJosephPearce, bool hasKateSkorija, bool hasKevinDavis, bool hasKyleHubbard, bool hasMarielHamson, bool hasMeganHepner, bool hasMichealHansen, bool hasNoelKirkland, bool hasPeterGrimm, bool hasSaraKane, bool hasSeanDowns, bool hasSpencerMoody, bool hasTaylorPhillips, bool hasTaylorSomers, bool hasTeresaRosinksi, bool hasThomasGlenn, bool hasTristanEmmerson, bool hasTysonLackey, bool hasBugStatusNav, bool hasProtectingDataNav, bool hasCloningDataNav, bool usesJquery, bool usesWebpack, bool usesNodeJs, bool usesHtml, bool usesAspDotnetMvc, bool usesSwagger, bool usesBootstrap, bool usesCss, bool usesJavascript, bool usesCsharp, bool hasSpecificationsDataNav, bool requiresPostman, bool requiresVscode, bool requiresMysql, bool requiresDotnetCore, bool hasAppSettings, bool hasDatabaseMigrations, bool hasApiCrudSection, bool hasPaginationSection, bool hasNpmInstall, bool hasDotnetInstall, bool requiresNodeJs)
    {
      Markdown readmeText = new Markdown();
      
      //HERO IMAGE
      readmeText.AddText("heroOpen", "<h1 align='center'><img width='900' height='450' src='");
      readmeText.AddText("heroURL", heroURL);
      readmeText.AddText("heroClose", "'><br>" );

      //TITLE
      readmeText.AddText("titleOpen", "**<h1 align = 'center'>");
      readmeText.AddText("title", title);
      readmeText.AddText("titleClose", "**");
      
      //OPTIONAL: TAGLINE
      readmeText.AddText("taglineOpen", "*<h2 align ='center'>");
      readmeText.AddText("tagline", tagline);
      readmeText.AddText("taglineClose", "*");

      //NAVIGATION
      readmeText.AddText("navigationBar", "<h3 align ='center'>•<a href='#requirements'> Requirements</a> •<a href='#setup'> Setup</a> •<a href='#technologies-used'> Technologies</a> •<a href='#❤️contributors'> Contributors</a>");
      readmeText.AddText("navClose", "</h3>");

      //ABOUT SECTION
      readmeText.AddText("aboutOpen", "<h3 align='center'>" );
      readmeText.AddText("about", about);
      readmeText.AddText("aboutClose", "</h3>");      
   
      //OPTIONAL: BUG SECTION
      ViewBag.hasBugStatusNav = hasBugStatusNav;
      readmeText.AddText("hasBugStatusNav", " •<a href='#known-bugs'> Bugs</a>");
      readmeText.AddText("bugSectionHeader", "# **KNOWN BUGS**");
      readmeText.AddText("bugStatus", bugStatus);
      readmeText.AddText("bugOpen", "_**" );
      readmeText.AddText("bugMiddle", " as of:** ");
      readmeText.AddText("bugDate", bugDate);
      readmeText.AddText("bugClose", "_");       
     
      //REQUIREMENTS SECTION
      readmeText.AddText("requirementSectionHeader", "# **REQUIREMENTS**");
      ViewBag.requiresPostman = requiresPostman;
      ViewBag.requiresVscode = requiresVscode;
      ViewBag.requiresMysql = requiresMysql;
      ViewBag.requiresDotnetCore = requiresDotnetCore;
      ViewBag.requiresNodeJs = requiresNodeJs;
      readmeText.AddText("requiresPostman", "_[Postman](https://www.postman.com/)_");
      readmeText.AddText("requiresVscode", "_[Visual Studio Code](https://code.visualstudio.com/)_");
      readmeText.AddText("requiresMysql", "_[MySql Workbench](https://www.mysql.com/products/workbench/)_");
      readmeText.AddText("requiresDotnetCore", "_[.Net Core v2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)_");
      readmeText.AddText("requiresNodeJs", "_[Node.js](https://nodejs.org/en/)_");

      //OPTIONAL: SPECIFICATIONS SECTION
      readmeText.AddText("specificationsSectionHeader", "# **SPECIFICATIONS**");
      ViewBag.hasSpecificationsDataNav = hasSpecificationsDataNav;
      readmeText.AddText("hasSpecificationsDataNav", " •<a href='#specifications'> Specs</a>"); 
      
      //TECHNOLOGIES USED
      readmeText.AddText("technologiesSectionHeader", "# **TECHNOLOGIES USED**");
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
      
      //SETUP OVER-ARCHING PARENT HEADER//
      readmeText.AddText("setupSectionHeader", "# **SETUP**");

      //optional: CLONING SECTION
      readmeText.AddText("cloningSectionHeader", "## **CLONING**");
      ViewBag.hasCloningDataNav = hasCloningDataNav;
      readmeText.AddText("hasCloningDataNav", " •<a href='#cloning'> Cloning</a>");
      readmeText.AddText("cloningTutorial1", "* Copy the repo link as shown in the image below");
      readmeText.AddText("cloningTutorial2", "![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif 'How to clone repo')");
      readmeText.AddText("cloningTutorial3", "* Paste the link in the field provided by VsCode as thown in the image below");
      readmeText.AddText("cloningTutorial4", "* You will be prompted to open the directory once you have cloned it. Select 'open'");
      readmeText.AddText("cloningTutorial5", "![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif 'Cloning from Github within VSCode')");

      //optional: PROTECTING DATA SECTION
      readmeText.AddText("protectionSectionHeader", "# **PROTECTING YOUR DATA**");
      ViewBag.hasProtectingDataNav = hasProtectingDataNav;
      readmeText.AddText("hasProtectingDataNav", " •<a href='#protecting-your-data'> Protecting Data</a>");
      readmeText.AddText("protectionTutorial1", "* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.");
      readmeText.AddText("protectionTutorial2", "* Step 2: commit that .gitignore file (this prevents your sensitive information like your API key being shown to others). **DO NOT PROCEED UNTIL YOU DO THIS!**");
      readmeText.AddText("protectionTutorial3", "![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image-3.jpg 'Set up instructions')");

      //optional: APP SETTINGS JSON
      readmeText.AddText("AppSettingsHeader", "# **APP SETTINGS**");
      ViewBag.hasAppSettings = hasAppSettings;
      readmeText.AddText("hasAppSettings", " •<a href='#app-settings'> AppSettings</a>");
      readmeText.AddText("appSettingsTutorial1", "**You need to update your username and password in the appsettings.json file.**");
      readmeText.AddText("appSettingsTutorial2", "_By default these are set to user:root and an empty password. If you are unsure, refer to the settings for your MySqlWorkbench._");
      readmeText.AddText("appSettingsTutorial3", "![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)");

      //optional: DATABASE WITH MIGRATIONS SECTION
      readmeText.AddText("DatabaseMigrationsHeader", "# **DATABASE WITH MIGRATIONS**");
      ViewBag.hasDatabaseMigrations = hasDatabaseMigrations;
      readmeText.AddText("hasDatabaseMigrations", " •<a href='#database-with-migrations'> Database</a>");
      readmeText.AddText("DatabaseMigrationTutorial1", "with the root project folder open in your code editor, execute the following in your terminal:");
      readmeText.AddText("DatabaseMigrationTutorial2", "``cd ProjectName``");
      readmeText.AddText("DatabaseMigrationTutorial6", "``dotnet restore``");
      readmeText.AddText("DatabaseMigrationTutorial10", "``dotnet build``");
      readmeText.AddText("DatabaseMigrationTutorial14", "``dotnet ef database update``");

      //optional: API CRUD SECTION
      readmeText.AddText("ApiCrudHeader", "# **POSTMAN API REQUESTS**");
      ViewBag.hasApiCrudSection = hasApiCrudSection;
      readmeText.AddText("hasApiCrudSection", " •<a href='#postman-api-requests'> API</a>");
      readmeText.AddText("ApiCrudTutorial1", "## TO GET AN ITEM");
      readmeText.AddText("ApiCrudTutorial2", "* Open Postman");
      readmeText.AddText("ApiCrudTutorial3", "* Set your request to type 'GET'");
      readmeText.AddText("ApiCrudTutorial4", "* http://localhost:5000/api/items/ (for index of all)");
      readmeText.AddText("ApiCrudTutorial5", "* http://localhost:5000/api/items/id (for specific item details)");
      readmeText.AddText("ApiCrudTutorial6", "* Hit Send");
      readmeText.AddText("ApiCrudTutorial7", "## TO ADD AN ITEM");
      readmeText.AddText("ApiCrudTutorial8", "* Open Postman");
      readmeText.AddText("ApiCrudTutorial9", "* Set your request to type 'POST'");
      readmeText.AddText("ApiCrudTutorial10", "* http://localhost:5000/api/items/");
      readmeText.AddText("ApiCrudTutorial11", "* Select Body Tab");
      readmeText.AddText("ApiCrudTutorial12", "* Select Raw Radio Button");
      readmeText.AddText("ApiCrudTutorial13", "* Select JSON from dropdown");
      readmeText.AddText("ApiCrudTutorial14", "* Write your addition to the database in the following format");
      readmeText.AddText("ApiCrudTutorial15", "<br>");
      readmeText.AddText("ApiCrudTutorial18", "``{itemId: 1, itemName: 'Mark', itemDate: '8/13/2020', itemDetails: 'big''}``");
      readmeText.AddText("ApiCrudTutorial26", "* Hit Send");
      readmeText.AddText("ApiCrudTutorial27", "## TO EDIT AN ITEM");
      readmeText.AddText("ApiCrudTutorial28", "* Open Postman");
      readmeText.AddText("ApiCrudTutorial29", "* Make a GET request for the id you wish to edit");
      readmeText.AddText("ApiCrudTutorial30", "* http://localhost:5000/api/items/id");
      readmeText.AddText("ApiCrudTutorial31", "* You can select the returned item data and paste that into your request body section for editing.");
      readmeText.AddText("ApiCrudTutorial32", "* Once you have completed your edits.");
      readmeText.AddText("ApiCrudTutorial33", "* Set your request to Put");
      readmeText.AddText("ApiCrudTutorial34", "* Hit Send");
      readmeText.AddText("ApiCrudTutorial35", "## TO DELETE AN ITEM");
      readmeText.AddText("ApiCrudTutorial36", "* Open Postman");
      readmeText.AddText("ApiCrudTutorial37", "* Set your route in Postman to the id you wish to delete");
      readmeText.AddText("ApiCrudTutorial38", "* Set your request to Delete");
      readmeText.AddText("ApiCrudTutorial39", "* Hit Send");

      //optional: PAGINATION SECTION
      readmeText.AddText("ApiCrudTutorial40", "# **USING PAGINATION**");
      ViewBag.hasPaginationSection = hasPaginationSection;
      readmeText.AddText("hasPaginationSection", " •<a href='#pagination'> Pagination</a>");
      readmeText.AddText("ApiCrudTutorial41", "* you can use routing in this structure when making your requests to limit the return data");
      readmeText.AddText("ApiCrudTutorial42", "* adjust the PageNumber and PageSize values in your request to do so");
      readmeText.AddText("ApiCrudTutorial43", "* http://localhost:5000/api/items/page?PageNumber=2&PageSize=5");
      readmeText.AddText("ApiCrudTutorial44", "<br>");

      //LINE CARRIAGE//
      readmeText.AddText("lineBreak", "<br>");


      //MIDPOINT--------->SPLIT

      //INSTALL OVER-ARCHING PARENT HEADER//
      readmeText.AddText("installSectionHeader", "# **INSTALL**");

      //optional: NpmInstall SECTION
      readmeText.AddText("hasNpmInstallHeader", "## **INSTALLING WITH NODE**");
      ViewBag.hasNpmInstall = hasNpmInstall;
      readmeText.AddText("npmInstallTutorial1", "with the root project folder open in your code editor, execute the following in your terminal:");
      readmeText.AddText("npmInstallTutorial2", "``cd ProjectName``");
      readmeText.AddText("npmInstallTutorial3", "``npm install``");
      readmeText.AddText("npmInstallTutorial4", "``npm run build``");


      //optional: DATABASE WITH MIGRATIONS SECTION
      readmeText.AddText("hasDotnetInstallHeader", "## **INSTALLING WITH DOTNET**");
      ViewBag.hasDotnetInstall = hasDotnetInstall;
      readmeText.AddText("DotnetInstallTutorial1", "with the root project folder open in your code editor, execute the following in your terminal:");
      readmeText.AddText("DotnetInstallTutorial2", "``cd ProjectName``");
      readmeText.AddText("DotnetInstallTutorial3", "``dotnet restore``");
      readmeText.AddText("DotnetInstallTutorial4", "``dotnet build``");
      readmeText.AddText("DotnetInstallTutorial6", "``dotnet watch run``");



      //CONTRIBUTORS
      readmeText.AddText("contributorsSectionHeader", "# **❤️Contributors**");
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
      
      //KEYWORDS
      readmeText.AddText("keyword1", keyword1);
      readmeText.AddText("keyword2", keyword2);
      readmeText.AddText("keyword3", keyword3);
      readmeText.AddText("keyword4", keyword4);
      readmeText.AddText("keyword5", keyword5);
      readmeText.AddText("keyword6", keyword6);

      //LICENSE
      readmeText.AddText("mitHeader", "## **License**");
      readmeText.AddText("mitLicense1", "![alt text][logo]");
      readmeText.AddText("mitLicense2", "[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'");

      return View(readmeText);
    }
    }

  }

