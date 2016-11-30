using Nancy;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/game"] = _ => {
        string user1choice = Request.Form["user1choice"];
        string user2choice = Request.Form["user2choice"];
        RPSGame newRPSGame = new RPSGame(user1choice, user2choice);
        return View["result.cshtml", newRPSGame];
      };
    }
  }
}
