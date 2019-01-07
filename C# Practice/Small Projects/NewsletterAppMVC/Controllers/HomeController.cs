using NewsletterAppMVC.Models;
using NewsletterAppMVC.viewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new Signup();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.Signups.Add(signup);
                    db.SaveChanges();
                }
                    //string queryString = @"INSERT INTO Signups (FirstName, LastName, EmailAddress) VALUES
                    //                        (@FirstName, @LastName, @EmailAddress)";

                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                    //    SqlCommand command = new SqlCommand(queryString, connection);
                    //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    //    command.Parameters["@FirstName"].Value = firstName;
                    //    command.Parameters["@LastName"].Value = lastName;
                    //    command.Parameters["@EmailAddress"].Value = emailAddress;

                    //    connection.Open();
                    //    command.ExecuteNonQuery();
                    //    connection.Close();
                    //}
                    return View("Success");
            }
        }


    }
}