using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using mvcDemo.Models;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace mvcDemo.Controllers
{
    public class AssignmentController : Controller
        
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FeverTest()
        {
            Fever obj = new Fever(); // We have to send the obj here, we send the obj model in the view 
            return View(obj);
        }

        [HttpPost]
        public IActionResult FeverTest(Fever obj)
        {
            if (obj.BodyTemp > 37.8)
                obj.Message = "You have a fever";
            else
                obj.Message = "You don't have a fever";

            //ViewBag.Msg = obj.Message;
            return View(obj);
        }

        [HttpGet]
        public IActionResult GuessingGame()
        {
            Random rd = new Random();
            int secretNumber = rd.Next(0, 500);
            HttpContext.Session.SetInt32("SNumber", secretNumber);
            int index = 0;
            HttpContext.Session.SetInt32("index", index);
            Guessing obj = new Guessing();
            obj.SNumber = secretNumber;
            return View(obj);
        }

        [HttpPost]
        public IActionResult GuessingGame(Guessing obj)
        {
            int Index = (int)HttpContext.Session.GetInt32("index");
            
            var Snum = HttpContext.Session.GetInt32("SNumber");
            obj.SNumber = (int)Snum;

            if (obj.Guess < obj.SNumber)
            {
                //Index += Index + 1;
                obj.Message = "You guess is smaller";
            }
                
            else if (obj.Guess > obj.SNumber)
            {
                //Index += Index + 1;
                obj.Message = "Your guess is higher";
            }
            else
                obj.Message = "Bingo! You guessed it.";
            ViewBag.Index = Index;
            return View(obj);
        }
    }
}
