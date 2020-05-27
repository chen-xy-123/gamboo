using gamboo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gamboo.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        gambooEntities db = new gambooEntities();
        //登录
        public ActionResult AdminLogin()
        {
            return View();
        }
        //查看游戏角色信息
        public ActionResult AdminGameRole()
        {

            return View(db.GameRole.ToList());
        }
        //查看详细游戏角色信息
        public ActionResult MinuteGameRole(int id)
        {
            var a = db.GameRole.Find(id);
            return View(a);
        }
        //删除游戏角色信息
        public ActionResult DeleteGameRole(int id)
        {
            var a = db.GameRole.Find(id);
            db.GameRole.Remove(a);
            db.SaveChanges();
            return RedirectToAction("AdminGameRole");
        }
        //修改游戏角色信息
        public ActionResult EditGameRole(int id)
        {
            var a = db.GameRole.Find(id);
            db.Entry(a).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("AdminGameRole");
        }
        [HttpPost]
        public ActionResult EditGameRole(GameRole gameRole)
        {
            db.Entry(gameRole).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("AdminGameRole");
        }
    }
}