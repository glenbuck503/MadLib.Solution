using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using PuppyMadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult SelectStory() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/puppyform")]
    public ActionResult PuppyForm() { return View(); }

    [Route("/results")]
    public ActionResult Results(string noun, string verb)
    {
      MadLib myLetterVariable = new MadLib();
      myLetterVariable.Noun = noun;
      myLetterVariable.Verb = verb;
  
      return View(myLetterVariable);
    }

    [Route("/puppy")]
    public ActionResult Puppy(string puppy, string breed)
    {
      PuppyMadLib puppyVariable = new PuppyMadLib();
    
     
      puppyVariable.Puppy = puppy;
      puppyVariable.Breed = breed;
      return View(puppyVariable);
    }
  }
}