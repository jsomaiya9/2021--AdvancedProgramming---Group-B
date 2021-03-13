using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BARDSports.Models;

namespace BARDSports.Controllers
{
    public class PlayerFansController : Controller
    {
        private BARDSportsDBContext db = new BARDSportsDBContext();

        // GET: PlayerFans
        public ActionResult Index()
        {
            var playerFansModels = db.PlayerFansModels.Include(p => p.Player).Include(p => p.User);
            return View(playerFansModels.ToList());
        }

        // GET: PlayerFans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerFansModel playerFansModel = db.PlayerFansModels.Find(id);
            if (playerFansModel == null)
            {
                return HttpNotFound();
            }
            return View(playerFansModel);
        }

        // GET: PlayerFans/Create
        public ActionResult Create()
        {
            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname");
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Email");
            return View();
        }

        // POST: PlayerFans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerFansId,PlayerId,UserId")] PlayerFansModel playerFansModel)
        {
            if (ModelState.IsValid)
            {
                db.PlayerFansModels.Add(playerFansModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname", playerFansModel.PlayerId);
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Email", playerFansModel.UserId);
            return View(playerFansModel);
        }

        // GET: PlayerFans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerFansModel playerFansModel = db.PlayerFansModels.Find(id);
            if (playerFansModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname", playerFansModel.PlayerId);
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Email", playerFansModel.UserId);
            return View(playerFansModel);
        }

        // POST: PlayerFans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerFansId,PlayerId,UserId")] PlayerFansModel playerFansModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerFansModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlayerId = new SelectList(db.PlayerModels, "PlayerId", "Firstname", playerFansModel.PlayerId);
            ViewBag.UserId = new SelectList(db.UserModels, "UserId", "Email", playerFansModel.UserId);
            return View(playerFansModel);
        }

        // GET: PlayerFans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerFansModel playerFansModel = db.PlayerFansModels.Find(id);
            if (playerFansModel == null)
            {
                return HttpNotFound();
            }
            return View(playerFansModel);
        }

        // POST: PlayerFans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerFansModel playerFansModel = db.PlayerFansModels.Find(id);
            db.PlayerFansModels.Remove(playerFansModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
