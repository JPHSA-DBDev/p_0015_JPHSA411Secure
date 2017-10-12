using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPHSA411Secure.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        #region Admin Dept ================================
        
        [Authorize(Roles = "jphsa411Secure_Admin")]
        public ActionResult Admin_Dept()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        #endregion //BHCS DEPT ============================================
        #region BHCS Dept ================================

        [AllowAnonymous]
        public ActionResult BHCS_Dept()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        #endregion //BHCS DEPT ============================================

        #region IT Dept ================================


        [Authorize(Roles = "IT")]
        public ActionResult IT_Dept()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
        //
        [Authorize(Roles = "IT")]
        public ActionResult IT_Dept_Printers()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        //
        [Authorize(Roles = "IT")]
        public ActionResult IT_Dept_Servers_Consoles()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        //
        [Authorize(Roles = "IT")]
        public ActionResult IT_Dept_References()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        //
        [Authorize(Roles = "IT")]
        public ActionResult IT_Dept_Links()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }


        #endregion //IT DEPT ============================================



        [Authorize(Roles = "OBHForm")]
        public ActionResult OBHForm()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }



        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}