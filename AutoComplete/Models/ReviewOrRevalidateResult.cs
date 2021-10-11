using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplete.Models
{
    public static class ReviewOrRevalidateResult
    {

        public class Rootobject
        {
            public Tripinfo[] tripInfos { get; set; }
            public Searchquery searchQuery { get; set; }
            public string bookingId { get; set; }
            public Totalpriceinfo totalPriceInfo { get; set; }
            public Status status { get; set; }
            public Conditions conditions { get; set; }
        }

        public class Searchquery
        {
            public Routeinfo[] routeInfos { get; set; }
            public string cabinClass { get; set; }
            public Paxinfo paxInfo { get; set; }
            public string searchType { get; set; }
            public Searchmodifiers searchModifiers { get; set; }
            public bool isDomestic { get; set; }
        }

        public class Paxinfo
        {
            public int ADULT { get; set; }
            public int CHILD { get; set; }
            public int INFANT { get; set; }
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
            public string name { get; set; }
            public string cityCode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
        }

        public class Tocityorairport
        {
            public string code { get; set; }
            public string name { get; set; }
            public string cityCode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
        }

        public class Totalpriceinfo
        {
            public Totalfaredetail totalFareDetail { get; set; }
        }

        public class Totalfaredetail
        {
            public Fc fC { get; set; }
            public Afc afC { get; set; }
        }

        public class Fc
        {
            public float TAF { get; set; }
            public float NF { get; set; }
            public float BF { get; set; }
            public float TF { get; set; }
        }

        public class Afc
        {
            public TAF TAF { get; set; }
        }

        public class TAF
        {
            public float OT { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float MFT { get; set; }
            public float YQ { get; set; }
        }

        public class Status
        {
            public bool success { get; set; }
            public int httpStatus { get; set; }
        }

        public class Conditions
        {
            public object[] ffas { get; set; }
            public bool isa { get; set; }
            public Dob dob { get; set; }
            public bool iecr { get; set; }
            public bool isBA { get; set; }
            public int st { get; set; }
            public DateTime sct { get; set; }
            public Gst gst { get; set; }
        }

        public class Dob
        {
            public bool adobr { get; set; }
            public bool cdobr { get; set; }
            public bool idobr { get; set; }
        }

        public class Gst
        {
            public bool gstappl { get; set; }
            public bool igm { get; set; }
        }

        public class Tripinfo
        {
            public Si[] sI { get; set; }
            public Totalpricelist[] totalPriceList { get; set; }
        }

        public class Si
        {
            public string id { get; set; }
            public Fd fD { get; set; }
            public int stops { get; set; }
            public object[] so { get; set; }
            public int duration { get; set; }
            public Da da { get; set; }
            public Aa aa { get; set; }
            public string dt { get; set; }
            public string at { get; set; }
            public bool iand { get; set; }
            public bool isRs { get; set; }
            public int sN { get; set; }
            public Ssrinfo ssrInfo { get; set; }
        }

        public class Fd
        {
            public Ai aI { get; set; }
            public string fN { get; set; }
            public string eT { get; set; }
        }

        public class Ai
        {
            public string code { get; set; }
            public string name { get; set; }
            public bool isLcc { get; set; }
        }

        public class Da
        {
            public string code { get; set; }
            public string name { get; set; }
            public string cityCode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public string terminal { get; set; }
        }

        public class Aa
        {
            public string code { get; set; }
            public string name { get; set; }
            public string cityCode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public string terminal { get; set; }
        }

        public class Ssrinfo
        {
            public BAGGAGE[] BAGGAGE { get; set; }
            public MEAL[] MEAL { get; set; }
        }

        public class BAGGAGE
        {
            public string code { get; set; }
            public float amount { get; set; }
            public string desc { get; set; }
        }

        public class MEAL
        {
            public string code { get; set; }
            public float amount { get; set; }
            public string desc { get; set; }
        }

        public class Totalpricelist
        {
            public Fd1 fd { get; set; }
            public string fareIdentifier { get; set; }
            public string id { get; set; }
            public Pc pc { get; set; }
        }

        public class Fd1
        {
            public ADULT ADULT { get; set; }
            public CHILD CHILD { get; set; }
            public INFANT INFANT { get; set; }
        }

        public class ADULT
        {
            public Fc1 fC { get; set; }
            public Afc1 afC { get; set; }
            public int sR { get; set; }
            public Bi bI { get; set; }
            public int rT { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
            public bool mI { get; set; }
        }

        public class Fc1
        {
            public float TAF { get; set; }
            public float NF { get; set; }
            public float BF { get; set; }
            public float TF { get; set; }
        }

        public class Afc1
        {
            public TAF1 TAF { get; set; }
        }

        public class TAF1
        {
            public float OT { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float MFT { get; set; }
            public float YQ { get; set; }
        }

        public class Bi
        {
            public string iB { get; set; }
            public string cB { get; set; }
        }

        public class CHILD
        {
            public Fc2 fC { get; set; }
            public Afc2 afC { get; set; }
            public int sR { get; set; }
            public Bi1 bI { get; set; }
            public int rT { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
            public bool mI { get; set; }
        }

        public class Fc2
        {
            public float TAF { get; set; }
            public float NF { get; set; }
            public float BF { get; set; }
            public float TF { get; set; }
        }

        public class Afc2
        {
            public TAF2 TAF { get; set; }
        }

        public class TAF2
        {
            public float OT { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float MFT { get; set; }
            public float YQ { get; set; }
        }

        public class Bi1
        {
            public string iB { get; set; }
            public string cB { get; set; }
        }

        public class INFANT
        {
            public Fc3 fC { get; set; }
            public Afc3 afC { get; set; }
            public Bi2 bI { get; set; }
            public int rT { get; set; }
            public bool mI { get; set; }
        }

        public class Fc3
        {
            public float TAF { get; set; }
            public float NF { get; set; }
            public float BF { get; set; }
            public float TF { get; set; }
        }

        public class Afc3
        {
            public TAF3 TAF { get; set; }
        }

        public class TAF3
        {
            public float MF { get; set; }
            public float AGST { get; set; }
            public float MFT { get; set; }
        }

        public class Bi2
        {
            public string cB { get; set; }
        }

        public class Pc
        {
            public string code { get; set; }
            public string name { get; set; }
            public bool isLcc { get; set; }
        }

    }
}