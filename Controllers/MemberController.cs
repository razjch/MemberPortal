using MemberPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public ActionResult Index()
        {
            AuthenticatedUser model = new AuthenticatedUser();
            model.MemberId = Convert.ToInt32(HttpContext.Session.GetInt32("MemberId"));
            model.Token = HttpContext.Session.GetString("Token");
            model.Name = HttpContext.Session.GetString("Name");
            return View(model);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
