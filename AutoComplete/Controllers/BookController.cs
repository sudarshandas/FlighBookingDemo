using System;
using System.Collections.Generic;
using System.Globalization;
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
                var result = review.reviewrevalidate(id);
                var rec = JsonConvert.DeserializeObject<ReviewOrRevalidateResult.Rootobject>(result);
                List<ReviewOrRevalidateResult.Rootobject> root = new List<ReviewOrRevalidateResult.Rootobject>();
                root.Add(rec);
                DateTime atDate = Convert.ToDateTime(root[0].tripInfos[0].sI[0].at.Split(new Char[] { 'T' }, StringSplitOptions.None)[0]);

                atDate = new DateTime(atDate.Year, atDate.Month, atDate.Day);
                string arriveDate = atDate.ToString("ddd','MMM' 'dd' 'yyyy");

                DateTime dtDate = Convert.ToDateTime(root[0].tripInfos[0].sI[0].dt.Split(new Char[] { 'T' }, StringSplitOptions.None)[0]);
                dtDate = new DateTime(dtDate.Year, dtDate.Month, dtDate.Day);
                string depatureDate = dtDate.ToString("ddd','MMM' 'dd' 'yyyy");

                int duration = root[0].tripInfos[0].sI[0].duration;
                double hou, min;
                string hour = "0h", minute = "0m";

                hou = (duration - duration % 60) / 60;
                min = (duration - hou * 60);

                hour = hou.ToString() + "h";
                minute = min.ToString() + "m";

                ViewBag.durationh = hour;
                ViewBag.durationm = minute;
                ViewBag.atDate = arriveDate;
                ViewBag.dtDate = depatureDate;
                return View(root);
            
            
        }
    }
}