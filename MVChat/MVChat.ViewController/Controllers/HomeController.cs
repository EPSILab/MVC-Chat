using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVChat.Model;

namespace MVChat.ViewController.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        private static List<User> _users = new List<User>
        {
            new User {Name = "dbottiau"},
            new User {Name = "jbvigneron"}
        };

        private static List<Message> _messages = new List<Message>
        {
            new Message {Writer = _users[0], Content = "Ey !", Date = new DateTime(2014, 4, 21, 13, 27, 42)},
            new Message {Writer = _users[1], Content = "Ca va ?", Date = new DateTime(2014, 4, 21, 13, 27, 57)},
            new Message {Writer = _users[0], Content = "T'as vu Cortana ?", Date = new DateTime(2014, 4, 21, 13, 28, 1)},
            new Message {Writer = _users[1], Content = "Yep", Date = new DateTime(2014, 4, 21, 13, 28, 13)}
        };

        #endregion


        #region Constructor

        public HomeController()
        {
        }

        #endregion


        #region Action methods

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(_messages.OrderByDescending(m => m.Date));
        }

        //
        // POST: /Home/Login

        [HttpPost]
        public ActionResult Login(string name)
        {
            var existingUser = _users.FirstOrDefault(u => u.Name == name);

            if (existingUser != null)
                Session["user"] = existingUser;
            else
            {
                var newUser = new User { Name = name };
                _users.Add(newUser);
                Session["user"] = newUser;
            }

            return RedirectToAction("Index");
        }

        //
        // POST: /Home/PostMessage

        [HttpPost]
        public ActionResult PostMessage(Message message)
        {
            message.Date = DateTime.Now;
            message.Writer = Session["user"] as User;

            _messages.Add(message);

            return RedirectToAction("Index");
        }

        #endregion
    }
}
