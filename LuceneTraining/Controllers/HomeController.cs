using LuceneTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuceneTraining.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index()
        {
            LuceneSearch.AddUpdateLuceneIndex(SampleDataRepository.GetAll()); 
            var sampleData = new SampleData();
            return View(sampleData);
        }

        [HttpPost]
        public ActionResult Index(SampleData sampleData)
        {
            ViewBag.Results = LuceneSearch.Search(sampleData.Description);
            ViewBag.ShowResults = true;
            return View(sampleData);
        }
    }
}
