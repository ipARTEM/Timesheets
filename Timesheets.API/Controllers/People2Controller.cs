using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Timesheets.API.Controllers
{
    public class People2Controller : Controller
    {
        // GET: People2Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: People2Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People2Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People2Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: People2Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People2Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: People2Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People2Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
