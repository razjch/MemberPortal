using MemberPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Controllers
{
    public class AuthController : Controller
    {
        // GET: AuthController
        [HttpGet]
        public ActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://20.83.9.34");
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", subscription.Token);

            StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Auth/Login/", content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                AuthenticatedUser user = JsonConvert.DeserializeObject<AuthenticatedUser>(jsonString);

                HttpContext.Session.SetString("Token", user.Token);
                HttpContext.Session.SetInt32("MemberId", user.MemberId);
                HttpContext.Session.SetString("Name", user.Name);


                ViewBag.Message = "logedIn";

                return RedirectToAction("Index", "Member");
            }
            else
            {
                ViewBag.Message = "Invalid Credentials... Check Your Id And Password Again";
                return View("Login");
            }
        }
    }
}
