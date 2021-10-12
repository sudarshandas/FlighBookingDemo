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
using AutoComplete.Models;
using AutoComplete.ViewModel;
using System.Web.Script.Serialization;
using System.Data;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        db Db = new db();
        //string json;
        //GET:HOME
        public ActionResult Index()
        {
            //AvailableFlight available = new AvailableFlight();
            //json=available.Flight();
            //var rec = JsonConvert.DeserializeObject<FlightSearchResponse>(json);
            ////List<SI> list =JsonConvert.DeserializeObject<List<SI>>(json);  
            //return View(rec);
            //ViewBag.TravelClass = Enum.GetValues(TravelClass);
            var Trav = from OnewayDomesticSearchQuery.TravelClass e in Enum.GetValues(typeof(OnewayDomesticSearchQuery.TravelClass))
                       select e;
                       
            ViewBag.TravelClass = new SelectList(Trav, "Cls");
            return View();
        }

        public JsonResult GetRecord(string prefix)

       {

            DataSet ds = Db.GetAirport(prefix);

            List<GetCity> searchlist = new List<GetCity>();

            foreach (DataRow dr in ds.Tables[0].Rows)

            {

                searchlist.Add(new GetCity
                {
                    City = dr["municipality"].ToString() + "(" + dr["iata_code"].ToString() + "),"+ dr["name"].ToString(),
                   
                });

            }

            return Json(searchlist);

        }
        [HttpPost]
        public ActionResult SearchResults(OnewayDomesticSearchQuery.RootObject fc)
        {
            ViewBag.City = fc.searchQuery.routeInfos[0].fromCityOrAirport.code;
            ViewBag.City1 = fc.searchQuery.routeInfos[0].toCityOrAirport.code;
            ViewBag.ADULT = fc.searchQuery.paxInfo.ADULT;
            ViewBag.CHILD = fc.searchQuery.paxInfo.CHILD;
            ViewBag.INFANT = fc.searchQuery.paxInfo.INFANT;
            ViewBag.cabinClass = fc.searchQuery.cabinClass;
            AvailableFlight availale = new AvailableFlight();
            var json = new JavaScriptSerializer().Serialize(fc);           

            var ResultJson= availale.Flight(fc);
            var rec = JsonConvert.DeserializeObject<OnewayDomesticResult.Rootobject>(ResultJson);
            
            
            TempData["OnewayDomesticResult"] = rec;
            TempData["onewayDomesticSearchQuery"] = fc;

            return RedirectToAction("SeachView");
        }

        public ActionResult SeachView()
        {
            //This Action and View For OnewayDomectic Search Only


            var model = TempData["OnewayDomesticResult"] as OnewayDomesticResult.Rootobject;
            var model1 = TempData["onewayDomesticSearchQuery"] as OnewayDomesticSearchQuery.RootObject;
            List<OnewayDomesticResult.Rootobject> root = new List<OnewayDomesticResult.Rootobject>();
            List<OnewayDomesticSearchQuery.RootObject> root1 = new List<OnewayDomesticSearchQuery.RootObject>();
            OnewayDomesticSearchQuery.RootObject exeModel = new OnewayDomesticSearchQuery.RootObject();
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


























        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}