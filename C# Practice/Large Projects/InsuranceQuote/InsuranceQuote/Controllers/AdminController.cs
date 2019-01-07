using InsuranceQuote.Models;
using InsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuote.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quotes = db.InsuranceQuotes;
                var quoteVms = new List<Quote>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new Quote();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.Email = quote.Email;
                    quoteVm.Rate = quote.Rate;
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}