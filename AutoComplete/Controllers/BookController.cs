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
        public ActionResult Index(string id)
        {
            ReviewRevalidate review = new ReviewRevalidate();
            var result =review.reviewrevalidate(id);
            var rec = JsonConvert.DeserializeObject<ReviewOrRevalidateResult.Rootobject>(result);
            List<ReviewOrRevalidateResult.Rootobject> root = new List<ReviewOrRevalidateResult.Rootobject>();
            root.Add(rec);
            int duration = root[0].tripInfos[0].sI[0].duration;
            float dive;
            string hour = "0h", minute = "0m";
            if (duration>60)
            {
                dive = duration / 60;
                string h = dive.ToString().Split(new [] { '.' }, StringSplitOptions.None)[0];
                if (h.Length > 1)
                {
                    string m = dive.ToString().Split(new[] { '.' }, StringSplitOptions.None)[1];
                    minute = m.ToString() + "m";
                }
                hour = h.ToString() + "h";
                
            }
            else if(duration == 60)
            {
                hour = "1h";
                minute = "0m";
            }
            else
            {
                hour = "0m";
                minute = duration.ToString() + "m";
            }
            ViewBag.durationh = hour;
            ViewBag.durationm = minute;
            return View(root);
        }
    }
}