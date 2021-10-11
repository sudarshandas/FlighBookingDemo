using AutoComplete.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Xml;

namespace AutoComplete.Models
{
    public class AvailableFlight
    {
        public airport db = new airport();
        string BaseUrl = "https://apitest.tripjack.com/fms/v1/air-search-all";
        string apikey = "7114315c476d94-4ef2-4e21-83e8-527d56a0c529";
        static string json1;
        OnewayDomesticSearchQuery.RootObject root = new OnewayDomesticSearchQuery.RootObject();
        static string text;


        public string Flight (OnewayDomesticSearchQuery.RootObject root)
        {
            string City = root.searchQuery.routeInfos[0].fromCityOrAirport.code;
            string City1 = root.searchQuery.routeInfos[0].toCityOrAirport.code;
            string ADULT = root.searchQuery.paxInfo.ADULT;
            string CHILD = root.searchQuery.paxInfo.CHILD;
            string INFANT = root.searchQuery.paxInfo.INFANT;
            string cabinClass = root.searchQuery.cabinClass;
            string travelDate = root.searchQuery.routeInfos[0].travelDate;
            bool direct = root.searchQuery.searchModifiers.isDirectFlight;
            text = "{\"searchQuery\":{\"cabinClass\":\""+cabinClass+"\",\"paxInfo\":{\"ADULT\":\""+ADULT+"\",\"CHILD\":\""+CHILD+"\",\"INFANT\":\""+INFANT+"\"},\"routeInfos\":[{\"fromCityOrAirport\":{\"code\":\""+City+"\"},\"toCityOrAirport\":{\"code\":\""+City1+"\"},\"travelDate\":\""+ travelDate + "\"}],\"searchModifiers\":{\"isDirectFlight\":"+direct.ToString().ToLower()+",\"isConnectingFlight\":false}}}";
            JObject json = JObject.Parse(text);
            //var test= JsonConvert.DeserializeObject<FromSearch>(text);
            List<FlightSearch> Flight = new List<FlightSearch>();

            var clie = new RestClient(BaseUrl);
            clie.Timeout = -1;
            var Req = new RestRequest(Method.POST);
            Req.AddHeader("Content-Type", "application/json");
            Req.AddHeader("apikey", "7114315c476d94-4ef2-4e21-83e8-527d56a0c529");
            Req.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse res = clie.Execute(Req);
            json1 = res.Content;
            DataSet ds = new DataSet();
            ds = jsonToDataSet(json1);


            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress=new Uri(BaseUrl);
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("apikey",apikey));
            //    //client.PostAsync
            //    string text = "{\"searchQuery\":{\"cabinClass\":\"ECONOMY\",\"paxInfo\":{\"ADULT\":\"1\",\"CHILD\":\"0\",\"INFANT\":\"0\"},\"routeInfos\":[{\"fromCityOrAirport\":{\"code\":\"DEL\"},\"toCityOrAirport\":{\"code\":\"CCU\"},\"travelDate\":\"2021-10-03\"}],\"searchModifiers\":{\"isDirectFlight\":true,\"isConnectingFlight\":false}}}";
            //    HttpResponseMessage Res = await client.PostAsJsonAsync("",JObject.Parse(text));
            //    if(Res.IsSuccessStatusCode)
            //    {
            //        var FlightResponse = Res.Content.ReadAsStringAsync().Result;
            //        Flight = JsonConvert.DeserializeObject<List<FlightSearch>>(FlightResponse);
            //    }
            //    return View(Flight);
            //}
            //return View(json1);

            return json1;
        
        }
        public static DataSet jsonToDataSet(string jsonString)
        {
            try
            {
                XmlDocument xd = new XmlDocument();
                jsonString = "{ \"rootNode\": {" + jsonString.Trim().TrimStart('{').TrimEnd('}') + "} }";
                xd = (XmlDocument)JsonConvert.DeserializeXmlNode(jsonString);
                DataSet ds = new DataSet();
                ds.ReadXml(new XmlNodeReader(xd));
                return ds;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        //public static void MergeObjectProp(List<ResultView> resultView,List<Rootobject> roorObj)
        //{
        //    if(resultView != null && roorObj != null)
        //    {
        //        if(roorObj.)
        //    }
        //}
        
        
    }
}