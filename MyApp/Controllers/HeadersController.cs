using MyApp.Models;
using MyApp.Models.Entity;
using MyApp.Models.View;
using MyApp.Services;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class HeadersController : Controller
    {
        private  readonly HeaderService _service = new HeaderService();
        // GET: Headers
        public ActionResult Index()
        {
            return View(_service.Search(null));
        }

        // GET: Headers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Header header = _service.Find(id);
            if (header == null)
            {
                return HttpNotFound();
            }
            return View(header);
        }

        // GET: Headers/Create
        public ActionResult Create()
        {
            EditHeaderView viewModel = new EditHeaderView()
            {
                Header = new Header()
                {
                    Details = new List<Detail>() { new Detail() }
                }
            };
            return View(viewModel);
        }

        // POST: Headers/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditHeaderView formValues)
        {
            if (ModelState.IsValid)
            {
                _service.Add(formValues.Header);
                _service.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formValues);
        }

        // GET: Headers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Header header = _service.Find(id);
            if (header == null)
            {
                return HttpNotFound();
            }
            return View(header);
        }

        // POST: Headers/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,AppDiv,CreatedAt,UpdatedAt")] Header header)
        {
            if (ModelState.IsValid)
            {
                _service.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(header);
        }

        // GET: Headers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Header header = _service.Find(id);
            if (header == null)
            {
                return HttpNotFound();
            }
            return View(header);
        }

        // POST: Headers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Header header = _service.Find(id);
            _service.Delete(header);
            _service.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //_service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
