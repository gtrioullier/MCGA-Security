﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.Framework.Localization.Kernel.Interfaces.Services;
using ASF.Framework.Localization.Kernel.Interfaces.Services.UnitOfWork;
using ASF.UI.Process;

namespace ASF.UI.WbSite.Areas.Categories.Controllers
{
    public class CategoryController : Controller
    {
        
        public CategoryController(IUnitOfWorkManager unitOfWorkManager,
            ILocalizationService localizationService,
            ISettingsService settingsService)
            
        {
            
        }
        // GET: Categories/Category
        public ActionResult Index()
        {
            var cpf = new CategoryProcess();
            var data = cpf.Find(2);

            var cp = new CategoryProcess();
            var lista = cp.SelectList();
            return View(lista);
        }
    }
}