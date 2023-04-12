using Newtonsoft.Json;
using ProductAllTool.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WEB.DataAccess;
using static WEB.Models.MainModel;

namespace WEB.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginAcc(LoginAcc lst)
        {
            try
            {
                var query = BaseConnectionSql.ExecuteList_Helper<getUserLoginAcc>("web", "sp_LoginAcc", lst.UserName,lst.UserPassword);
                if (query.Count > 0)
                {
                    Session["uid"] = query[0].UserId;
                    Session["username"] = query[0].UserName;
                    Session["role"] = query[0].UserRole;
                return Json(1);
                }
                else
                {
                    Session["err"] = "Tài khoản hoặc mật khẩu không đúng!";
                    return View();
                }
            }
            catch (Exception ex)
            {
                LogBuild.CreateLogger(JsonConvert.SerializeObject(ex), "CreateCategory");
                return Json(null);
            }
        }
        public ActionResult LogoutAcc()
        {
            Session.Contents.RemoveAll();

            return RedirectToAction("Index","Home");
        }
    }
}