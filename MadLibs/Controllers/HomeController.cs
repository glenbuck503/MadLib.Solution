using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
  

  [Route("/results")]
    public ActionResult Results(string noun, string verb)
    {
      MadLib myLetterVariable = new MadLib();
      myLetterVariable.Noun = noun;
      myLetterVariable.Verb = verb;

      return View(myLetterVariable);
    }
  }
}