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
    public class SubscriptionController : Controller
    {
        [HttpPost]
        public ActionResult Subscribe(IFormCollection form)
        {
            int prescriptionId = Convert.ToInt32(form["Id"]);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://20.84.192.31");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            SubscriptionDTO model = new SubscriptionDTO
            {
                PrescriptionId = prescriptionId,
                Token = token
            };

            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Subscription/Subscribe",content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                MemberSubscription member = JsonConvert.DeserializeObject<MemberSubscription>(jsonString);
                ViewBag.MessageSubscribe = "Successfully Subscribe :)";
                return View(member);
            }
            else
            {
                if(response.StatusCode == HttpStatusCode.NoContent)
                    ViewBag.MessageSubscribe = "Already Subscribed... :)";
                else if (response.StatusCode == HttpStatusCode.NotFound)
                    ViewBag.MessageSubscribe = "Wrong Prescription ID... :(";

                else
                    ViewBag.MessageSubscribe = "This Drug is not available at your location...Unable To Subscribe :(";
                int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client.GetAsync("/api/Subscription/GetAllPrescription/"+memberId).Result;

                string jsonString = response1.Content.ReadAsStringAsync().Result;
                List<MemberPrescription> prep = JsonConvert.DeserializeObject<List<MemberPrescription>>(jsonString);
                return View("GetAllPrescription", prep);
            }

        }     


        [HttpPost]
        public ActionResult UnSubscribe(IFormCollection form)
        {
            int prescriptionId = Convert.ToInt32(form["Id"]);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://20.84.192.31");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            SubscriptionDTO model = new SubscriptionDTO
            {
                PrescriptionId = prescriptionId,
                Token = token
            };

            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Subscription/UnSubscribe",content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                MemberSubscription member = JsonConvert.DeserializeObject<MemberSubscription>(jsonString);
                ViewBag.MessageUnsubscribe = "Successfully Unsubscribed :(";
                return View("Subscribe", member);
            }
            else
            {
                ViewBag.MessageUnsubscribe = "Your Payment is Pending... You cannot UnSubscribe :)";
                int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client.GetAsync("/api/Subscription/GetAllPrescription/"+memberId).Result;
                

                string jsonString = response1.Content.ReadAsStringAsync().Result;
                List<MemberPrescription> prep = JsonConvert.DeserializeObject<List<MemberPrescription>>(jsonString);
                return View("GetAllPrescription", prep);
            }
        }

        // GET: DrugController/Details/5
        [HttpGet]
        public ActionResult GetAllPrescription()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://20.84.192.31");
            string token = HttpContext.Session.GetString("Token");
            int memberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/subscription/GetAllPrescription/"+memberId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                List<MemberPrescription> pres = JsonConvert.DeserializeObject<List<MemberPrescription>>(jsonString);

                return View(pres);
            }
            else
            {
                ViewBag.Message = "Subscription Server is down... Kindly Check After Sometime!!!";
                return RedirectToAction("Index", "Member");
            }
        }
    }
}
