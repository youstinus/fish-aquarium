using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using FishAquarium.Configs;
using FishAquarium.Models;
using Microsoft.EntityFrameworkCore;

namespace FishAquarium.Controllers
{
    public class AquariumController : Controller
    {
        private FishAquariumContext db = new FishAquariumContext();

        // GET: Aquarium
        public async Task<ActionResult> Index()
        {
            return View(await db.Aquarium.ToListAsync());
        }

        // GET: Aquarium/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aquarium aquarium = await db.Aquarium.FindAsync(id);
            if (aquarium == null)
            {
                return HttpNotFound();
            }
            return View(aquarium);
        }

        // GET: Aquarium/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aquarium/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Capacity,Mass,Length,Width,Heigth,GlassThickness,FkPortion")] Aquarium aquarium)
        {
            if (ModelState.IsValid)
            {
                db.Aquarium.Add(aquarium);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(aquarium);
        }

        // GET: Aquarium/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aquarium aquarium = await db.Aquarium.FindAsync(id);
            if (aquarium == null)
            {
                return HttpNotFound();
            }
            return View(aquarium);
        }

        // POST: Aquarium/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Capacity,Mass,Length,Width,Heigth,GlassThickness,FkPortion")] Aquarium aquarium)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aquarium).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(aquarium);
        }

        // GET: Aquarium/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aquarium aquarium = await db.Aquarium.FindAsync(id);
            if (aquarium == null)
            {
                return HttpNotFound();
            }
            return View(aquarium);
        }

        // POST: Aquarium/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Aquarium aquarium = await db.Aquarium.FindAsync(id);
            db.Aquarium.Remove(aquarium);
            await db.SaveChangesAsync();
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
