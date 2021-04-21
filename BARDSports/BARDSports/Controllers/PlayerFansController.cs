using BARDSports.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BARDSports.Controllers
{
    public class PlayerFansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: PlayerFans
        public ActionResult Index(int PlayerId)
        {
            var userId = User.Identity.GetUserId();
            PlayerFansModel model = new PlayerFansModel();
            model.PlayerId = PlayerId;
            model.Id = userId;
            db.PlayerFansModels.Add(model);
            db.SaveChanges();
            return View();
        }
    }
} 