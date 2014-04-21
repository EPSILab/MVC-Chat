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

        private IList<User> _users;
        private IList<Message> _messages; 

#endregion


#region Constructor

        public HomeController()
        {
            _users = new List<User>
            {
                new User {Name = "dbottiau"},
                new User {Name = "jbvigneron"}
            };

            _messages = new List<Message>
            {
                new Message {Writer = _users[0], Text = "Ey !", Date = new DateTime(2014, 4, 21, 13, 27, 42)},
                new Message {Writer = _users[1], Text = "Ca va ?", Date = new DateTime(2014, 4, 21, 13, 27, 57)},
                new Message {Writer = _users[0], Text = "T'as vu Cortana ?", Date = new DateTime(2014, 4, 21, 13, 28, 1)},
                new Message {Writer = _users[1], Text = "Yep", Date = new DateTime(2014, 4, 21, 13, 28, 13)}
            };
        }

#endregion


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
        public ActionResult Login()
        {
            return View();
        }

#endregion
    }
}
