using System.Collections.Generic;


namespace MakeMeTakeMeReadMe.Models
{
  public class Markdown
  {
    private Dictionary<string, string> _markdownSnippetList = new Dictionary<string, string>();

    public bool hasAboutSection { get; set; }
    public bool hasSpecsSection { get; set; }
    public bool hasLicenseMit { get; set; }
    public bool hasSection { get; set; }
    public bool hasSection { get; set; }
    public bool hasSection { get; set; }
    public bool hasSection { get; set; }
    public bool hasSection { get; set; }
    public bool hasSection { get; set; }
    public bool hasSection { get; set; }
    public bool usesPhotoshop { get; set; }
    public bool usesMysql { get; set; }
    public bool usesVscode { get; set; }
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
