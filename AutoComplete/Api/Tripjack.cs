using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoComplete.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AutoComplete.Api
{
    public class Tripjack
    {
        string BaseUrl = "https://apitest.tripjack.com/fms/v1/air-search-all";
        string apikey = "7114315c476d94-4ef2-4e21-83e8-527d56a0c529";
        static string returnJson, bodyText;
        OnewayDomesticSearchQuery.RootObject root = new OnewayDomesticSearchQuery.RootObject();
        
        public string apiCall(OnewayDomesticSearchQuery.RootObject root,string json)
        {
            //string City = root.searchQuery.routeInfos[0].fromCityOrAirport.code.Split(new Char[] { '(', ')' }, StringSplitOptions.None)[1];
            //string City1 = root.searchQuery.routeInfos[0].toCityOrAirport.code.Split(new Char[] { '(',')' }, StringSplitOptions.None)[1];
            string fromCode = root.searchQuery.routeInfos[0].fromCityOrAirport.code;
            string toCode = root.searchQuery.routeInfos[0].toCityOrAirport.code;
            string ADULT = root.searchQuery.paxInfo.ADULT;
            string CHILD = root.searchQuery.paxInfo.CHILD;
            string INFANT = root.searchQuery.paxInfo.INFANT;
            string cabinClass = root.searchQuery.cabinClass;
            string travelDate = root.searchQuery.routeInfos[0].travelDate;
            string returnDate, returnBody="";
            //if (root.searchQuery.routeInfos[0].returnDate != null)
            //{
            //    returnDate = root.searchQuery.routeInfos[0].returnDate;
            //    returnBody = ",{\"fromCityOrAirport\":{\"code\":\"" + toCode + "\"},\"toCityOrAirport\":{\"code\":\"" + fromCode + "\"},\"travelDate\":\"" + returnDate + "\"}";
            //}
            //else
            //    returnBody = null;

            //bool direct = root.searchQuery.searchModifiers.isDirectFlight;
            bodyText = "{\"searchQuery\":{\"cabinClass\":\"" + cabinClass + "\",\"paxInfo\":{\"ADULT\":\"" + ADULT + "\",\"CHILD\":\"" + CHILD + "\",\"INFANT\":\"" + INFANT + "\"},\"routeInfos\":[{\"fromCityOrAirport\":{\"code\":\"" + fromCode + "\"},\"toCityOrAirport\":{\"code\":\"" + toCode + "\"},\"travelDate\":\"" + travelDate + "\"}" + returnBody + "],\"searchModifiers\":{\"isDirectFlight\":true,\"isConnectingFlight\":false}}}";
            JObject body = JObject.Parse(bodyText);

            var restclient = new RestClient(BaseUrl);
            restclient.Timeout = -1;
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("apikey", "7114315c476d94-4ef2-4e21-83e8-527d56a0c529");
            restRequest.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = restclient.Execute(restRequest);
            returnJson = response.Content;
            return returnJson;

        }
    }
}