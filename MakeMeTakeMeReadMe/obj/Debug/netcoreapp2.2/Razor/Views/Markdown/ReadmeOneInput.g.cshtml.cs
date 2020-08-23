#pragma checksum "C:\Users\trist\Epicodus-Week-13\MakeMeTakeMeReadMe.Solution\MakeMeTakeMeReadMe\Views\Markdown\ReadmeOneInput.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108f552e48edf00e5275dc2d6d129f35345d59b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Markdown_ReadmeOneInput), @"mvc.1.0.view", @"/Views/Markdown/ReadmeOneInput.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Markdown/ReadmeOneInput.cshtml", typeof(AspNetCore.Views_Markdown_ReadmeOneInput))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108f552e48edf00e5275dc2d6d129f35345d59b6", @"/Views/Markdown/ReadmeOneInput.cshtml")]
    public class Views_Markdown_ReadmeOneInput : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MakeMeTakeMeReadMe.Models.Markdown>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\trist\Epicodus-Week-13\MakeMeTakeMeReadMe.Solution\MakeMeTakeMeReadMe\Views\Markdown\ReadmeOneInput.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(73, 10770, true);
            WriteLiteral(@"
  <div class=""container"">
    <form action=""/readmeOneOutput"" method=""post"">
      <div class=""row"">

        <div class=""col-md-6"">
          <div class=""form-group"">
            <label for=""title"">title</label>
            <input class=""form-control"" id=""title"" name=""title"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""tagline"">tagline</label>
            <input class=""form-control"" id=""tagline"" name=""tagline"" type=""text"">
          </div>
            <div class=""form-group"">
            <label for=""heroURL"">hero url (see documentation for stocks)</label>
            <input class=""form-control"" id=""heroURL"" name=""heroURL"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""about"">about section</label>
            <input class=""form-control"" id=""about"" name=""about"" type=""text"">
          </div>
          
          <div class=""form-group"">
            <b>Technologies Used: </b><br />
            <span><i");
            WriteLiteral(@"nput type=""checkbox"" name=""usesPhotoshop"" value=""true""> : Photoshop</span>
            <br>
            <span><input type=""checkbox"" name=""usesVscode"" value=""true""> : Vscode</span>
            <br>
            <span><input type=""checkbox"" name=""usesMysql"" value=""true""> : Mysqlworkbench</span>
            <br>
            <span><input type=""checkbox"" name=""usesJavascript"" value=""true""> : Javascript</span>
            <br>
            <span><input type=""checkbox"" name=""usesCss"" value=""true""> : CSS</span>
            <br>
            <span><input type=""checkbox"" name=""usesBootstrap"" value=""true""> : Bootstrap</span>
            <br>
            <span><input type=""checkbox"" name=""usesCsharp"" value=""true""> : C#</span>
            <br>
            <span><input type=""checkbox"" name=""usesSwagger"" value=""true""> : Swagger</span>
            <br>
            <span><input type=""checkbox"" name=""usesAspDotnetMvc"" value=""true""> : Asp.Net MVC</span>
            <br>
            <span><input type=""checkbox"" n");
            WriteLiteral(@"ame=""usesHtml"" value=""true""> : HTML</span>
            <br>
            <span><input type=""checkbox"" name=""usesNodeJs"" value=""true""> : NodeJs</span>
            <br>
            <span><input type=""checkbox"" name=""usesWebpack"" value=""true""> : Webpack</span>
            <br>
            <span><input type=""checkbox"" name=""usesJquery"" value=""true""> : Jquery</span>
          </div>
        </div>

        <div class=""col-md-6"">
          <div class=""form-group"">
            <h1>Topics (replace spaces with hyphens)</h1>
            <label for=""keyword1"">keyword-1</label>
            <input class=""form-control"" id=""keyword1"" name=""keyword1"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""keyword2"">keyword-2</label>
            <input class=""form-control"" id=""keyword2"" name=""keyword2"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""keyword3"">keyword-3</label>
            <input class=""form-control"" id=""keyword3"" na");
            WriteLiteral(@"me=""keyword3"" type=""text"">
          </div>
            <div class=""form-group"">
            <label for=""keyword4"">keyword-4</label>
            <input class=""form-control"" id=""keyword4"" name=""keyword4"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""keyword5"">keyword-5</label>
            <input class=""form-control"" id=""keyword5"" name=""keyword5"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""keyword6"">keyword-6</label>
            <input class=""form-control"" id=""keyword6"" name=""keyword6"" type=""text"">
          </div>
        </div>
        
        <div class=""col-md-6"">
          <div class=""form-group"">
          <b>Requirements: </b><br />
            <span><input type=""checkbox"" name=""requiresPostman"" value=""true""> : Postman</span>
            <br>
            <span><input type=""checkbox"" name=""requiresVscode"" value=""true""> : Vscode</span>
            <br>
            <span><input type=""checkbox"" nam");
            WriteLiteral(@"e=""requiresMysql"" value=""true""> : MySQL Workbench</span>
            <br>
            <span><input type=""checkbox"" name=""requiresDotnetCore"" value=""true""> : .NET Core</span>
            <br>
        </div>   

        </div>
        <div class=""col-md-6"">
          <div class=""form-group"">
            <b>Optional Setup Sections: </b><br />
            <span><input type=""checkbox"" name=""hasProtectingDataNav"" value=""true""> : Git ignore file handling?</span>
            <br>
            <span><input type=""checkbox"" name=""hasBugStatusNav"" value=""true""> : Add Bug Status?</span>
            <br>
            <span><input type=""checkbox"" name=""hasCloningDataNav"" value=""true""> : Add Cloning?</span>
            <br>
            <span><input type=""checkbox"" name=""hasAppSettings"" value=""true""> : Add AppSettings.json section?</span>
            <br>
            <span><input type=""checkbox"" name=""hasDatabaseMigrations"" value=""true""> : Database with Migrations?</span>
            <br>
            <span><");
            WriteLiteral(@"input type=""checkbox"" name=""hasApiCrudSection"" value=""true""> : Postman API CRUD Requests?</span>
            <br>
            <span><input type=""checkbox"" name=""hasSpecificationsDataNav"" value=""true""> : Add Specifications section?</span>
            <br>
            <span><input type=""checkbox"" name=""hasPaginationSection"" value=""true""> : Add Pagination section?</span>
          </div>
          <div class=""form-group"">
            <label for=""bugStatus"">bug status</label>
            <input class=""form-control"" id=""bugStatus"" name=""bugStatus"" type=""text"">
          </div>
          <div class=""form-group"">
            <label for=""bugDate"">bug status date</label>
            <input class=""form-control"" id=""bugDate"" name=""bugDate"" type=""text"">
          </div>


        </div>
        <div class=""col-md-4"">
          <div class=""form-group"">
            <b>Contributors: </b><br />
            <span><input type=""checkbox"" name=""hasAllisonSadin"" value=""true""> : Allison Sadin
            <br>");
            WriteLiteral(@"
            <span><input type=""checkbox"" name=""hasBenWhite"" value=""true""> : Ben White
            <br>
            <span><input type=""checkbox"" name=""hasBenRussell"" value=""true""> : Ben Russell
            <br>
            <span><input type=""checkbox"" name=""hasBeverlyPotts"" value=""true""> : Beverly Potts
            <br>
            <span><input type=""checkbox"" name=""hasBrittanyLindgren"" value=""true""> : Brittany Lindgren
            <br>
            <span><input type=""checkbox"" name=""hasChristineAugustine"" value=""true""> : Christine Augustine
            <br>
            <span><input type=""checkbox"" name=""hasChrisYoon"" value=""true""> : Chris Yoon
            <br>
            <span><input type=""checkbox"" name=""hasCodyFritz"" value=""true""> : Cody Fritz 
            <br>
            <span><input type=""checkbox"" name=""hasDeryckJackson"" value=""true""> : Deryck Jackson
            <br>
            <span><input type=""checkbox"" name=""hasErichRichter"" value=""true""> : Erich Richter
            <br>
       ");
            WriteLiteral(@"     <span><input type=""checkbox"" name=""hasEvgeniyaChernaya"" value=""true""> : Evgeniya Chernaya
            <br>
            <span><input type=""checkbox"" name=""hasFrederickErnest"" value=""true""> : Frederick Ernest 
            <br>

          </div>
        </div>
          <div class=""col-md-4"">
            <div class=""form-group"">
              <br>
            <span><input type=""checkbox"" name=""hasHannahBeinstein"" value=""true""> : Hannah Beinstein
            <br>
            <span><input type=""checkbox"" name=""hasIanGregg"" value=""true""> : Ian Gregg
            <br>
            <span><input type=""checkbox"" name=""hasIanScott"" value=""true""> : Ian Scott
            <br>
            <span><input type=""checkbox"" name=""hasJamesHenager"" value=""true""> : James Henager
            <br>
            <span><input type=""checkbox"" name=""hasJasonKhan"" value=""true""> : Jason Khan
            <br>
            <span><input type=""checkbox"" name=""hasJeffreyKim"" value=""true""> : Jeffrey Kim
            <br>
    ");
            WriteLiteral(@"        <span><input type=""checkbox"" name=""hasJohnNilsOlson"" value=""true""> : JohnNils Olson
            <br>
            <span><input type=""checkbox"" name=""hasJosephPearce"" value=""true""> : Joseph Pearce
            <br>
            <span><input type=""checkbox"" name=""hasKateSkorija"" value=""true""> : Kate Skorija
            <br>
            <span><input type=""checkbox"" name=""hasKevinDavis"" value=""true""> : Kevin Davis
            <br>
            <span><input type=""checkbox"" name=""hasKyleHubbard"" value=""true""> : Kyle Hubbard
            <br>
            <span><input type=""checkbox"" name=""hasMarielHamson"" value=""true""> : Mariel Hamson
            <br>
            
          </div>
        </div>
                  <div class=""col-md-4"">
            <div class=""form-group"">
              <br>
            <span><input type=""checkbox"" name=""hasMeganHepner"" value=""true""> : Megan Hepner
            <br>
            <span><input type=""checkbox"" name=""hasMichealHansen"" value=""true""> : Micheal Hansen
");
            WriteLiteral(@"            <br>
            <span><input type=""checkbox"" name=""hasNoelKirkland"" value=""true""> : Noel Kirkland
            <br>
            <span><input type=""checkbox"" name=""hasPeterGrimm"" value=""true""> : Peter Grimm
            <br>
            <span><input type=""checkbox"" name=""hasSaraKane"" value=""true""> : Sara Kane
            <br>
            <span><input type=""checkbox"" name=""hasSeanDowns"" value=""true""> : Sean Downs
            <br>
            <span><input type=""checkbox"" name=""hasSpencerMoody"" value=""true""> : Spencer Moody
            <br>
            <span><input type=""checkbox"" name=""hasTaylorPhillips"" value=""true""> : Taylor Phillips
            <br>
            <span><input type=""checkbox"" name=""hasTaylorSomers"" value=""true""> : Taylor Somers
            <br>
            <span><input type=""checkbox"" name=""hasTeresaRosinksi"" value=""true""> : Teresa Rosinksi
            <br>
            <span><input type=""checkbox"" name=""hasThomasGlenn"" value=""true""> : Thomas Glenn
            <br>
 ");
            WriteLiteral(@"           <span><input type=""checkbox"" name=""hasTristanEmmerson"" value=""true""> : Tristan Emmerson
            <br>
            <span><input type=""checkbox"" name=""hasTysonLackey"" value=""true""> : Tyson Lackey   
          </div>
        </div>
      </div>

      </div>
      <div class=""row"">
        <div class=""col-md-1"">
          <div class=""form-group"">
            <button type=""submit"" class=""btn btn-info"">MakeMeTakeMeReadMe</button>
          </div>
        </div>
      </div>
    </form>
  </div>


");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MakeMeTakeMeReadMe.Models.Markdown> Html { get; private set; }
    }
}
#pragma warning restore 1591
