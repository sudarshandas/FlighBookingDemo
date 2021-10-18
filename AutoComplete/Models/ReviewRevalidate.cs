using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplete.Models
{
    public class ReviewRevalidate
    {
        string text, json1;
        public string reviewrevalidate(string id)
        {
            try
            {
                //bool direct = root.searchQuery.searchModifiers.isDirectFlight;
                text = "{\"priceIds\":[\"" + id + "\"]}";
                JObject json = JObject.Parse(text);

                var clie = new RestClient("https://apitest.tripjack.com/fms/v1/review");
                clie.Timeout = -1;
                var Req = new RestRequest(Method.POST);
                Req.AddHeader("Content-Type", "application/json");
                Req.AddHeader("apikey", "7114315c476d94-4ef2-4e21-83e8-527d56a0c529");
                Req.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse res = clie.Execute(Req);
                json1 = res.Content;
                //DataSet ds = new DataSet();
                //ds = jsonToDataSet(json1);
                return json1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}