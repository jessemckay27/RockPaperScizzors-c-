using Nancy;
using System.Collections.Generic;
using RockPaperScizzors.Objects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
