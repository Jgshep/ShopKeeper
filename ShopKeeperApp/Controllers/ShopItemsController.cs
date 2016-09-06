using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopKeeper.Class;
using ShopKeeper.DataModel;

namespace ShopKeeperApp.Controllers
{
    public class ShopItemsController : Controller
    {
        private ShopItemContext db = new ShopItemContext();

        // GET: ShopItems
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }

        // GET: ShopItems/Details/5
        public ActionResult Details(int id)
        {
            ShopItem shopItem = db.Items.Find(id);
            if (shopItem == null)
            {
                return HttpNotFound();
            }
            return View(shopItem);
        }

        // GET: ShopItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Price")] ShopItem shopItem)
        {

            if (ModelState.IsValid)
            {
                db.Items.Add(shopItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopItem);
        }

        // GET: ShopItems/Edit/5
        public ActionResult Edit(int id)
        {
            ShopItem shopItem = db.Items.Find(id);
            if (shopItem == null)
            {
                return HttpNotFound();
            }
            return View(shopItem);
        }

        // POST: ShopItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Price")] ShopItem shopItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopItem);
        }

        // GET: ShopItems/Delete/5
        public ActionResult Delete(int id)
        {
            ShopItem shopItem = db.Items.Find(id);
            if (shopItem == null)
            {
                return HttpNotFound();
            }
            return View(shopItem);
        }

        // POST: ShopItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShopItem shopItem = db.Items.Find(id);
            db.Items.Remove(shopItem);
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
