using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoComplete.Models;
using Newtonsoft.Json;

namespace AutoComplete.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Review(string id)
        {
            ReviewRevalidate review = new ReviewRevalidate();
            var result =review.reviewrevalidate(id);
            var rec = JsonConvert.DeserializeObject<ReviewOrRevalidateResult.Rootobject>(result);
            List<ReviewOrRevalidateResult.Rootobject> root = new List<ReviewOrRevalidateResult.Rootobject>();
            root.Add(rec);
            int duration = root[0].tripInfos[0].sI[0].duration;
            double hou, min;
            string hour = "0h", minute = "0m";
            
                hou = (duration - duration % 60) / 60;
                min = (duration - hou * 60);
                            
                hour = hou.ToString() + "h";
                minute = min.ToString() + "m";

            
            //else if(duration == 60)
            //{
            //    hour = "1h";
            //    minute = "0m";
            //}
            //else
            //{
            //    hour = "0h";
            //    minute = duration.ToString() + "m";
            //}
            ViewBag.durationh = hour;
            ViewBag.durationm = minute;
            return View(root);
        }
    }
}