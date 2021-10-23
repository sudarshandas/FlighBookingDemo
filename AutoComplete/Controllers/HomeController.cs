using AutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Microsoft.Ajax.Utilities;
using System.Configuration;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using AutoComplete.ViewModel;
using System.Web.Script.Serialization;
using System.Data;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using AutoComplete.Api;


namespace AutoComplete.Controllers
{
    
    public class HomeController : Controller
    {

        //string json;
        //GET:HOME
        
        public ActionResult Index()
        {
            var Trav = from OnewayDomesticSearchQuery.TravelClass e in Enum.GetValues(typeof(OnewayDomesticSearchQuery.TravelClass))
                       select e;
                       
            ViewBag.TravelClass = new SelectList(Trav, "Cls");
            return View();
        }

        public JsonResult GetRecord(string prefix)
        {
            using (var context=new HAWAIADDAAEntities())
            {
                var data = context.AIRPORTS.Where(x => x.AIRPORTMunicipality.Contains(prefix) || x.AIRPORTIATACode.Contains(prefix)).Take(10).ToList();
                
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult SearchResults(OnewayDomesticSearchQuery.RootObject query)
        {
            Tripjack apiTripjack = new Tripjack();
            query.searchQuery.searchModifiers.isDirectFlight = true;
            var json = new JavaScriptSerializer().Serialize(query);           

            //var ResultJson= apiTripjack.apiCall(query,json);
           
            query.searchQuery.searchModifiers.isDirectFlight = false;
            var json2= new JavaScriptSerializer().Serialize(query);
            var ResultJson1 = apiTripjack.apiCall(query, json2);
            var searchResult = JsonConvert.DeserializeObject<OnewayDomesticResult.Rootobject>(ResultJson1);
            //var cou = searchResult.searchResult.tripInfos.ONWARD[2].sI[0].so != null;
            TempData["OnewayDomesticResult"] = searchResult;
            TempData["onewayDomesticSearchQuery"] = query;

            return RedirectToAction("SeachView");
        }

        public ActionResult SeachView()
        {
            //This Action and View For OnewayDomectic Search Only

            var model = TempData["OnewayDomesticResult"] as OnewayDomesticResult.Rootobject;
            var model1 = TempData["onewayDomesticSearchQuery"] as OnewayDomesticSearchQuery.RootObject;
            List<OnewayDomesticResult.Rootobject> root = new List<OnewayDomesticResult.Rootobject>();
            List<OnewayDomesticSearchQuery.RootObject> root1 = new List<OnewayDomesticSearchQuery.RootObject>();
            root.Add(model);
            root1.Add(model1);
            ViewBag.rootmodel = root;
            ViewBag.rootmodel1 = root1;
            //ResultView rv = new ResultView();
            //ViewBag.price=rv.CalPrice(root,model1);
            //return View(root.AsEnumerable());
            TempData["OnewayDomesticResult"] = model;
            TempData["onewayDomesticSearchQuery"] = model1;
            return View(root1);
        }
        
        [HttpPost]
        public ActionResult PostData(string cabinClass)
        {
            //var txt = fc.searchQuery.cabinClass;

            return View();
        }

    }
}