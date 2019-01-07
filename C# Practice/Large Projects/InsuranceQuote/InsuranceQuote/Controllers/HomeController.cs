using InsuranceQuote;
using InsuranceQuote.Models;
using InsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Just another sleezy insurance company...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can try to talk to us, but your response will depend on my coffee intake!";

            return View();
        }

        public ActionResult Quote(string firstName, string lastName, string emailAddress, string Age,
                                    string CarYear, string CarMake, string CarModel, string DUI, string Tickets, string Coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(Age) || string.IsNullOrEmpty(CarYear) || string.IsNullOrEmpty(CarMake) ||
                string.IsNullOrEmpty(CarModel) || string.IsNullOrEmpty(DUI) || string.IsNullOrEmpty(Tickets) || string.IsNullOrEmpty(Coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                int baserate = 50;
                int agerate = 0;
                int yearrate = 0;
                int makerate = 0;
                int modelrate = 0;
                double duirate = 1;
                double fullrate = 1;

                if (Convert.ToInt32(Age) < 18)
                {
                    agerate = 100;
                }
                else if (Convert.ToInt32(Age) < 25 && Convert.ToInt32(Age) > 18)
                {
                    agerate = 25;
                }
                else if (Convert.ToInt32(Age) > 100)
                {
                    agerate = 25;
                }

                if (Convert.ToInt32(CarYear) < 2000 || Convert.ToInt32(CarYear) > 2015)
                {
                    yearrate = 25;
                }
                
                if (CarMake == "Porsche")
                {
                    makerate = 25;
                }

                if (CarMake == "Porsche" && CarModel == "911 Carrera")
                {
                    modelrate = 25;
                }

                int ticketrate = Convert.ToInt32(Tickets) * 10;

                if (DUI == "dui")
                {
                    duirate = 1.25;
                }
                
                if (Coverage == "full")
                {
                    fullrate = 1.5;
                }
                
                int Rate = Convert.ToInt32((baserate + agerate + yearrate + makerate + modelrate + ticketrate) * duirate * fullrate);

                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var insurance = new Insurance();
                    insurance.FirstName = firstName;
                    insurance.LastName = lastName;
                    insurance.Email = emailAddress;
                    insurance.Age = Convert.ToInt32(Age);
                    insurance.CarYear = Convert.ToInt32(CarYear);
                    insurance.CarMake = CarMake;
                    insurance.CarModel = CarModel;
                    insurance.DUI = DUI;
                    insurance.Tickets = Convert.ToInt32(Tickets);
                    insurance.Coverage = Coverage;
                    insurance.Rate = Rate;

                    db.InsuranceQuotes.Add(insurance);
                    db.SaveChanges();
                }
                ViewBag.Message = "Your rate for insurance will be $" + Rate + " per month";
            }
            
            return View("Quote");
        }

    }
}