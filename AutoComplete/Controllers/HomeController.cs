﻿using AutoComplete.Models;
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
using AutoComplete.Api;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        db Db = new db();
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

            DataSet ds = Db.GetAirport(prefix);

            List<GetCity> searchlist = new List<GetCity>();

            foreach (DataRow dr in ds.Tables[0].Rows)

            {

                searchlist.Add(new GetCity
                {
                    City = dr["AIRPORTMunicipality"].ToString(),
                    iata= dr["AIRPORTIATACode"].ToString(),
                    name= dr["AIRPORTName"].ToString(),  
                    id= dr["AIRPORTID"].ToString()
                });

            }

            return Json(searchlist, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult SearchResults(OnewayDomesticSearchQuery.RootObject query)
        {
            Tripjack apiTripjack = new Tripjack();
            
            var json = new JavaScriptSerializer().Serialize(query);           

            var ResultJson= apiTripjack.apiCall(query,json);
            var searchResult = JsonConvert.DeserializeObject<OnewayDomesticResult.Rootobject>(ResultJson);
            
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