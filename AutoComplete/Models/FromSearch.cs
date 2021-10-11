using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplete.Models
{
    public class FromSearch
    {

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Root
    {
        public Searchquery searchQuery { get; set; }
    }
    public enum TravelClass
    {
        ECONOMY,
        BUSINESS,
        FIRST,
        PREMIUM_ECONOMY
    }
    public class Searchquery
    {
        public string cabinClass { get; set; }
        public Paxinfo paxInfo { get; set; }
        public Routeinfo[] routeInfos { get; set; }
        public Searchmodifiers searchModifiers { get; set; }
    }
    
    public class Paxinfo
    {
        public string ADULT { get; set; }
        public string CHILD { get; set; }
        public string INFANT { get; set; }
    }

    public class Searchmodifiers
    {
        public bool isDirectFlight { get; set; }
        public bool isConnectingFlight { get; set; }
    }

    public class Routeinfo
    {
        public Fromcityorairport fromCityOrAirport { get; set; }
        public Tocityorairport toCityOrAirport { get; set; }
        public string travelDate { get; set; }
    }

    public class Fromcityorairport
    {
        public string code { get; set; }
    }

    public class Tocityorairport
    {
        public string code { get; set; }
    }


}