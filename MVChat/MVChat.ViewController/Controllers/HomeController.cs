using System.Web.Mvc;
using MVChat.Model;

namespace MVChat.ViewController.Controllers
{
    public class HomeController : Controller
    {
        #region Action methods

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Home/Login

        [HttpPost]
        public ActionResult Login(string name)
        {
            Session["user"] = new User { Name = name };

            return RedirectToAction("Index");
        }

        #endregion
    }
}
