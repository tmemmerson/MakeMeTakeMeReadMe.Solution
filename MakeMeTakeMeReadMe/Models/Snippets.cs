using System.Collections.Generic;
namespace MakeMeTakeMeReadMe.Models
{
  public class Snippets
  {
    private Dictionary<string, string> _snippetList = new Dictionary<string, string>();

    public string GetSnippet(string key)
    {
      if (_snippetList.ContainsKey(key))
      {
        return _snippetList[key];
      }
      else
      {
        return "0";
      }
    }

    public void AddText(string key, string text)
    {
      _snippetList.Add(key, text);
    }

  }
}
