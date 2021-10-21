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
        public Airports db = new Airports();
        string BaseUrl = "https://apitest.tripjack.com/fms/v1/air-search-all";
        string apikey = "7114315c476d94-4ef2-4e21-83e8-527d56a0c529";
        static string json1;
        OnewayDomesticSearchQuery.RootObject root = new OnewayDomesticSearchQuery.RootObject();
        static string text;


        public string Flight (OnewayDomesticSearchQuery.RootObject root)
        {
            //string City = root.searchQuery.routeInfos[0].fromCityOrAirport.code.Split(new Char[] { '(', ')' }, StringSplitOptions.None)[1];
            //string City1 = root.searchQuery.routeInfos[0].toCityOrAirport.code.Split(new Char[] { '(',')' }, StringSplitOptions.None)[1];
            string City = root.searchQuery.routeInfos[0].fromCityOrAirport.code;
            string City1 = root.searchQuery.routeInfos[0].toCityOrAirport.code;
            string ADULT = root.searchQuery.paxInfo.ADULT;
            string CHILD = root.searchQuery.paxInfo.CHILD;
            string INFANT = root.searchQuery.paxInfo.INFANT;
            string cabinClass = root.searchQuery.cabinClass;
            string travelDate = root.searchQuery.routeInfos[0].travelDate;
            string returnDate,text2="";
            //if (root.searchQuery.routeInfos[0].returnDate != null)
            //{
            //    returnDate = root.searchQuery.routeInfos[0].returnDate;
            //    text2 = "{\"fromCityOrAirport\":{\"code\":\"" + City1 + "\"},\"toCityOrAirport\":{\"code\":\"" + City + "\"},\"travelDate\":\"" + returnDate + "\"}";
            //}
            //else
            //    text2 = null;
            
            //bool direct = root.searchQuery.searchModifiers.isDirectFlight;
            text = "{\"searchQuery\":{\"cabinClass\":\""+cabinClass+"\",\"paxInfo\":{\"ADULT\":\""+ADULT+"\",\"CHILD\":\""+CHILD+"\",\"INFANT\":\""+INFANT+"\"},\"routeInfos\":[{\"fromCityOrAirport\":{\"code\":\""+City+"\"},\"toCityOrAirport\":{\"code\":\""+City1+"\"},\"travelDate\":\""+ travelDate + "\"}"+text2+"],\"searchModifiers\":{\"isDirectFlight\":true,\"isConnectingFlight\":false}}}";
            JObject json = JObject.Parse(text);
           
            var clie = new RestClient(BaseUrl);
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