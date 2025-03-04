using BasicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicApp.Controllers
{
    public class FinalController : Controller
    {
        // GET: Final
        public ActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //_model = model;\
                if (Session["model"] == null)
                {
                    Session["Model"] = model;
                }
                else
                {
                    model = Session["model"] as RegisterViewModel;
                }
            }
            else
            {
                model = Session["model"] as RegisterViewModel;
            }

            return View(model);
        }

        [HttpPost]
        [MultipleButton(Name = "action", Argument = "LoadPrevious")]
        public ActionResult LoadPrevious(RegisterViewModel model)
        {
            RegisterViewModel rvm;

            if (Session["Model"] == null)
            {
                rvm = new RegisterViewModel();
            }
            else
            {
                rvm = Session["Model"] as RegisterViewModel;
            }

            rvm = RegisterViewModel.JoinModels(model, rvm);
            Session["model"] = rvm;

            return RedirectToAction("Index", "Name", new { Message = "" });
        }
    }
}