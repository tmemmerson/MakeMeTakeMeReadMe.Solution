using System.Collections.Generic;


namespace MakeMeTakeMeReadMe.Models
{
  public class Markdown
  {
    private Dictionary<string, string> _markdownSnippetList = new Dictionary<string, string>();

    public bool hasAllisonSadin { get; set; }
    public bool hasBenWhite { get; set; }
    public bool hasBenRussell { get; set; }
    public bool hasBeverlyPotts { get; set; }
    public bool hasBrittanyLindgren { get; set; }
    public bool hasChristineAugustine { get; set; }
    public bool hasChrisYoon { get; set; }
    public bool hasCodyFritz { get; set; }
    public bool hasDeryckJackson { get; set; }
    public bool hasErichRichter { get; set; }
    public bool hasEvgeniyaChernaya { get; set; }
    public bool hasFrederickErnest { get; set; }
    public bool hasHannahBeinstein { get; set; }
    public bool hasIanGregg { get; set; }
    public bool hasIanScott { get; set; }
    public bool hasJamesHenager { get; set; }
    public bool hasJasonKhan { get; set; }
    public bool hasJeffreyKim { get; set; }
    public bool hasJohnNilsOlson { get; set; }
    public bool hasJosephPearce { get; set; }
    public bool hasKateSkorija { get; set; }
    public bool hasKevinDavis { get; set; }
    public bool hasKyleHubbard { get; set; }
    public bool hasMarielHamson { get; set; }
    public bool hasMeganHepner { get; set; }
    public bool hasMichealHansen { get; set; }
    public bool hasNoelKirkland { get; set; }
    public bool hasPeterGrimm { get; set; }
    public bool hasSaraKane { get; set; }
    public bool hasSeanDowns { get; set; }
    public bool hasSpencerMoody { get; set; }
    public bool hasTaylorPhillips { get; set; }
    public bool hasTaylorSomers { get; set; }
    public bool hasTeresaRosinksi { get; set; }
    public bool hasThomasGlenn { get; set; }
    public bool hasTristanEmmerson { get; set; }
    public bool hasTysonLackey { get; set; }
    public bool hasAboutSection { get; set; }
    public bool hasSpecsSection { get; set; }
    public bool hasLicenseMit { get; set; }
    public bool hasSection { get; set; }
    public bool usesJavascript { get; set; }
    public bool usesCss { get; set; }
    public bool usesBootstrap { get; set; }
    public bool usesCsharp { get; set; }
    public bool usesSwagger { get; set; }
    public bool usesAspDotnetMvc { get; set; }
    public bool usesHtml { get; set; }
    public bool usesNodeJs { get; set; }
    public bool usesWebpack { get; set; }
    public bool usesJquery { get; set; }
    public bool usesPhotoshop { get; set; }
    public bool usesMysql { get; set; }
    public bool usesVscode { get; set; }
    public bool hasBugStatusNav { get; set; }
    public bool hasProtectingDataNav { get; set; }
    public bool hasCloningDataNav { get; set; }
    public bool requiresVscode { get; set; } //not implemented
    public bool requiresMysql { get; set; } //not implemented
  
    public string SectionHeaders(string key)
    {
      if (_markdownSnippetList.ContainsKey(key))
      {
        return _markdownSnippetList[key];
      }
      else
      {
        return "0";
      }
    }
    
    public void AddText(string key, string text)
    {
      _markdownSnippetList.Add(key, text);
    }

  }
}
