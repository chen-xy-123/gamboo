using gamboo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gamboo.Controllers
{
    public class GameRoleController : Controller
    {
        // GET: GameRole
        gambooEntities db = new gambooEntities();
        public ActionResult Role()
        {
            return View(db.GameRole.ToList());
        }
    }
}