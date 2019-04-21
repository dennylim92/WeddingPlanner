using System.Net.Http;
using System.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("LoggedID") != null)
            {
                List<Wedding> allWeddings = dbContext.Weddings
                .Include(w => w.Person)
                .Include(w => w.Guests)
                .ThenInclude(g => g.Person)
                .ToList();
                int? idUser = HttpContext.Session.GetInt32("LoggedID");
                ViewBag.idUser = idUser;
                return View(allWeddings);
            }
            ModelState.AddModelError("lEmail", "Please login to continue.");
            return View("Index");

        }

        [HttpPost("register")]
        public IActionResult RegisterUser(UserForm userForm)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == userForm.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                User newUser = new User()
                {
                FirstName = userForm.FirstName,
                LastName = userForm.LastName,
                Email = userForm.Email,
                Password = userForm.Password
                };
                

                PasswordHasher<UserForm> Hasher = new PasswordHasher<UserForm>();
                newUser.Password = Hasher.HashPassword(userForm, newUser.Password);

                dbContext.Add(newUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("LoggedID", newUser.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult LoginUser(LoginForm userSubmission)
        {
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.lEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("lEmail", "Invalid Email");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginForm>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.lPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("LoggedID", userInDb.UserId);
                int? idUser = HttpContext.Session.GetInt32("LoggedID");
                return RedirectToAction("Dashboard");
            }
            
                return View("Index");
            
        }

        [HttpGet("info/{weddingID}")]
        public IActionResult WeddingInfo(int weddingID)
        {
            if(HttpContext.Session.GetInt32("LoggedID") != null)
            {
                Wedding aWedding = dbContext.Weddings
                    .Where(w => w.WeddingId == weddingID)
                    .Include(w => w.Guests)
                    .ThenInclude(r => r.Person)
                    .SingleOrDefault();
                return View(aWedding);
            }
            ModelState.AddModelError("lEmail", "Please login to continue.");
            return View("Index");
        }


        [HttpGet("create")]
        public IActionResult WeddingPlan()
        {
            if(HttpContext.Session.GetInt32("LoggedID") != null)
            {
                return View();
            }
            ModelState.AddModelError("lEmail", "Please login to continue.");
            return View("Index");
        }

        [HttpPost("create/wedding")]
        public IActionResult CreateWedding(WeddingForm formWedding, Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                int weddingDate = formWedding.Date.DayOfYear;
                int Today = DateTime.Now.DayOfYear;
                if(weddingDate < Today)
                {
                    ModelState.AddModelError("Date", "Must create a wedding for a future date.");
                    return View("WeddingPlan");
                }
                int? idUser = HttpContext.Session.GetInt32("LoggedID");
                newWedding.Location = formWedding.Address;
                newWedding.UserId = (int)idUser;
                dbContext.Add(newWedding);
                dbContext.SaveChanges();
                // SELECTING ADDED WEDDING ID
                Wedding thisWeddingId = dbContext.Weddings
                .Where(w => w.WeddingId == newWedding.WeddingId)
                .SingleOrDefault();
                return RedirectToAction("WeddingInfo", new {weddingId = thisWeddingId.WeddingId});
            }
            return View("WeddingPlan");
        }

        [HttpGet("delete/{weddingID}")]
        public IActionResult Delete(int weddingID)
        {
            if(HttpContext.Session.GetInt32("LoggedID") != null)
            {
                int? idUser = HttpContext.Session.GetInt32("LoggedID");
                dbContext.Remove(dbContext.Weddings
                .Where(w => w.WeddingId == weddingID)
                .Where(w => w.Person.UserId == idUser)
                .SingleOrDefault());
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("lEmail", "Please login to continue.");
            return View("Index");
        }

        [HttpGet("rsvp/{weddingID}")]
        public IActionResult AddGuest(int weddingID)
        {
            if(HttpContext.Session.GetInt32("LoggedID") != null)
            {
                int? idUser = HttpContext.Session.GetInt32("LoggedID");
                RSVP newRSVP = new RSVP();
                newRSVP.UserId = (int)idUser;
                newRSVP.WeddingId = weddingID;
                dbContext.Add(newRSVP);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("lEmail", "Please login to continue.");
            return View("Index");
        }

        [HttpGet("unrsvp/{weddingID}")]
        public IActionResult RemoveGuest(int weddingID)
        {
            if(HttpContext.Session.GetInt32("LoggedID") != null)
            {
                int? idUser = HttpContext.Session.GetInt32("LoggedID");
                dbContext.Remove(dbContext.RSVPs
                    .Where(r => r.WeddingId == weddingID)
                    .Where(r => r.UserId == (int)idUser)
                    .SingleOrDefault());
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("lEmail", "Please login to continue.");
            return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

    }
}
