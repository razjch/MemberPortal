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
    public class DrugController : Controller
    {
        
        [HttpPost]
        public ActionResult GetById(IFormCollection form)
        {
            int Id = Convert.ToInt32(form["Id"]);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/Drug/getbyid/"+Id).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                Drug drug = JsonConvert.DeserializeObject<Drug>(jsonString);

                return View(drug);
            }
            else
            {

                ViewBag.MessageId = "Drug Not Found!!!";
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client.GetAsync("/api/Drug/getalldrugs/").Result;

                    string jsonString = response1.Content.ReadAsStringAsync().Result;
                    List<Drug> drugs = JsonConvert.DeserializeObject<List<Drug>>(jsonString);
                    return View("GetAllDrugs",drugs);
                
                
            }

        }

        [HttpPost]
        public ActionResult GetDispatchableStock(IFormCollection form)
        {
            int Id = Convert.ToInt32(form["Id"]);
            string location = form["Location"];
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            StringContent content = new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Drug/getStock/" + Id +"/"  +location,content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                DispatchableDrug drug = JsonConvert.DeserializeObject<DispatchableDrug>(jsonString);
                if (drug.Stock == 0)
                    ViewBag.MessageStock = "Sorry... We Donot have this Drug At Your Location";
                else
                {
                    ViewBag.MessageStock = "Your Required Drug is Avalable... Subscribe to Avail the Drug.";
                }
                
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response2 = client.GetAsync("/api/Drug/getalldrugs/").Result;

                string jsonString1 = response2.Content.ReadAsStringAsync().Result;
                List<Drug> drugs = JsonConvert.DeserializeObject<List<Drug>>(jsonString1);
                return View("GetAllDrugs", drugs);
            }
            else
            {
                ViewBag.MessageId = "Drug Not Found!!!";
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client.GetAsync("/api/Drug/getalldrugs/").Result;

                string jsonString = response1.Content.ReadAsStringAsync().Result;
                List<Drug> drugs = JsonConvert.DeserializeObject<List<Drug>>(jsonString);
                return View("GetAllDrugs", drugs);
            }
        }


        [HttpPost]
        public ActionResult GetByName(IFormCollection form)
        {
            string name = form["Name"];
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/Drug/getbyname/" + name).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                Drug drug = JsonConvert.DeserializeObject<Drug>(jsonString);

                return View("GetById", drug);
            }
            else
            {
                ViewBag.MessageId = "Drug Not Found!!!";
                //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                HttpResponseMessage response1 = client.GetAsync("/api/Drug/getalldrugs/").Result;

                string jsonString = response1.Content.ReadAsStringAsync().Result;
                List<Drug> drugs = JsonConvert.DeserializeObject<List<Drug>>(jsonString);
                return View("GetAllDrugs", drugs);
            }
        }

        // GET: DrugController/Details/5
        [HttpGet]
        public ActionResult GetAllDrugs()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080");
            string token = HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.GetAsync("/api/Drug/getalldrugs/").Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                List<Drug> drugs = JsonConvert.DeserializeObject<List<Drug>>(jsonString);

                return View(drugs);
            }
            else
            {
                ViewBag.Message = "Drug Server is down... Kindly Check After Sometime!!!";
                return RedirectToAction("Index", "Member");
            }
        }

        
    }
}
