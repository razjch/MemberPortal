using MemberPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Controllers
{
    public class RefillController : Controller
    {

        [HttpPost]
        public ActionResult CreateRefill(IFormCollection form)
        {
            int subscriptionId = Convert.ToInt32(form["Id"]);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9000");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            SubscriptionRefillDTO model = new SubscriptionRefillDTO
            {
                SubscriptionId = subscriptionId,
                Token = token
            };

            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Refill/CreateRefill", content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                RefillOrder member = JsonConvert.DeserializeObject<RefillOrder>(jsonString);
                ViewBag.MessageRefill = "Refill Id Generated :)";
                return View(member);
            }
            else
            {
                HttpClient client1 = new HttpClient();
                client1.BaseAddress = new Uri("http://localhost:9090");
                ViewBag.MessageRefill = "You need to subscribe first :(";
                int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
                client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client1.GetAsync("/api/Subscription/GetAllSubscription/" + memberId).Result;

                string jsonString = response1.Content.ReadAsStringAsync().Result;
                List<MemberSubscription> prep = JsonConvert.DeserializeObject<List<MemberSubscription>>(jsonString);
                return View("GetAllSubscription", prep);
            }

        }


        [HttpPost]
        public ActionResult GetRefillStatus(IFormCollection form)
        {
            int subscriptionId = Convert.ToInt32(form["Id"]);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9000");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //SubscriptionRefillDTO model = new SubscriptionRefillDTO
            //{
            //    SubscriptionId = subscriptionId,
            //    Token = token
            //};

            //StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/Refill/ViewRefillStatus/"+subscriptionId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                RefillOrder refillOrder = JsonConvert.DeserializeObject<RefillOrder>(jsonString);
                return View("CreateRefill",refillOrder);
            }
            else
            {
                HttpClient client1 = new HttpClient();
                client1.BaseAddress = new Uri("http://localhost:9090");
                ViewBag.MessageRefill = "You need to subscribe first :(";
                int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
                client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client1.GetAsync("/api/Subscription/GetAllSubscription/" + memberId).Result;

                string jsonString = response1.Content.ReadAsStringAsync().Result;
                List<MemberSubscription> prep = JsonConvert.DeserializeObject<List<MemberSubscription>>(jsonString);
                return View("GetAllSubscription", prep);
            }

        }

        [HttpGet]
        public ActionResult GetAllSubscription()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9090");
            string token = HttpContext.Session.GetString("Token");
            int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/subscription/GetAllSubscription/" + memberId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                List<MemberSubscription> mem = JsonConvert.DeserializeObject<List<MemberSubscription>>(jsonString);

                return View(mem);
            }
            else
            {
                ViewBag.Message = "Subscription Server is down... Kindly Check After Sometime!!!";
                return RedirectToAction("Index", "Member");
            }
        }

        [HttpPost]
        public ActionResult GetRefillDueStatus(IFormCollection form)
        {
            int subscriptionId = Convert.ToInt32(form["Id"]);
            string fromDate = form["Date"];

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9000");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/Refill/GetRefillDues/"+subscriptionId+"/"+fromDate).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                RefillDueDTO data = JsonConvert.DeserializeObject<RefillDueDTO>(jsonString);
                ViewBag.MessageRefillDue = $"SubscriptionId : {data.SubscriptionId} /n Refill Due Left {data.DueRefillTimes} Times";
                HttpClient client1 = new HttpClient();
                client1.BaseAddress = new Uri("http://localhost:9090");
                //string token = HttpContext.Session.GetString("Token");
                int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
                client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client1.GetAsync("/api/subscription/GetAllSubscription/" + memberId).Result;

                    string jsonString1 = response1.Content.ReadAsStringAsync().Result;
                    List<MemberSubscription> subs = JsonConvert.DeserializeObject<List<MemberSubscription>>(jsonString1);
                    return View("GetAllSubscription", subs);
            }
            else
            {
                ViewBag.MessageRefillDue = "Wrong Subscription Id Entered...";
                HttpClient client1 = new HttpClient();
                client1.BaseAddress = new Uri("http://localhost:9090");
                //string token = HttpContext.Session.GetString("Token");
                int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
                client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client1.GetAsync("/api/subscription/GetAllSubscription/" + memberId).Result;

                    string jsonString1 = response1.Content.ReadAsStringAsync().Result;
                    List<MemberSubscription> subs = JsonConvert.DeserializeObject<List<MemberSubscription>>(jsonString1);
                return View("GetAllSubscription", subs);
            }
        }
    }
}
