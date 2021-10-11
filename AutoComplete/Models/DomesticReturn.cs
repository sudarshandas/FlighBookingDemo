using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplete.Models
{
    public class DomesticReturn
    {
        public class Rootobject
        {
            public Searchresult searchResult { get; set; }
            public Status status { get; set; }
        }

        public class Searchresult
        {
            public Tripinfos tripInfos { get; set; }
        }

        public class Tripinfos
        {
            public RETURN[] RETURN { get; set; }
            public ONWARD[] ONWARD { get; set; }
        }

        public class RETURN
        {
            public Si[] sI { get; set; }
            public Totalpricelist[] totalPriceList { get; set; }
        }

        public class Si
        {
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
            public Ob oB { get; set; }
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

        public class Ob
        {
            public string code { get; set; }
            public string name { get; set; }
            public bool isLcc { get; set; }
        }

        public class Totalpricelist
        {
            public Fd1 fd { get; set; }
            public string fareIdentifier { get; set; }
            public string id { get; set; }
            public string[] msri { get; set; }
            public string sri { get; set; }
        }

        public class Fd1
        {
            public ADULT ADULT { get; set; }
            public INFANT INFANT { get; set; }
            public CHILD CHILD { get; set; }
        }

        public class ADULT
        {
            public Fc fC { get; set; }
            public Afc afC { get; set; }
            public int sR { get; set; }
            public Bi bI { get; set; }
            public int rT { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
            public bool mI { get; set; }
        }

        public class Fc
        {
            public float TF { get; set; }
            public float TAF { get; set; }
            public float BF { get; set; }
            public float NF { get; set; }
            public float NCM { get; set; }
        }

        public class Afc
        {
            public TAF TAF { get; set; }
            public NCM NCM { get; set; }
        }

        public class TAF
        {
            public float MFT { get; set; }
            public float OT { get; set; }
            public float YQ { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float MU { get; set; }
            public float YR { get; set; }
        }

        public class NCM
        {
            public float OT { get; set; }
            public float TDS { get; set; }
        }

        public class Bi
        {
            public string iB { get; set; }
            public string cB { get; set; }
        }

        public class INFANT
        {
            public Fc1 fC { get; set; }
            public Afc1 afC { get; set; }
            public Bi1 bI { get; set; }
            public int rT { get; set; }
            public bool mI { get; set; }
            public int sR { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
        }

        public class Fc1
        {
            public float TF { get; set; }
            public float TAF { get; set; }
            public float BF { get; set; }
            public float NF { get; set; }
        }

        public class Afc1
        {
            public TAF1 TAF { get; set; }
        }

        public class TAF1
        {
            public float MFT { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float YR { get; set; }
        }

        public class Bi1
        {
            public string cB { get; set; }
            public string iB { get; set; }
        }

        public class CHILD
        {
            public Fc2 fC { get; set; }
            public Afc2 afC { get; set; }
            public int sR { get; set; }
            public Bi2 bI { get; set; }
            public int rT { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
            public bool mI { get; set; }
        }

        public class Fc2
        {
            public float TF { get; set; }
            public float TAF { get; set; }
            public float BF { get; set; }
            public float NF { get; set; }
            public float NCM { get; set; }
        }

        public class Afc2
        {
            public TAF2 TAF { get; set; }
            public NCM1 NCM { get; set; }
        }

        public class TAF2
        {
            public float MFT { get; set; }
            public float OT { get; set; }
            public float YQ { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float YR { get; set; }
        }

        public class NCM1
        {
            public float OT { get; set; }
            public float TDS { get; set; }
        }

        public class Bi2
        {
            public string iB { get; set; }
            public string cB { get; set; }
        }

        public class ONWARD
        {
            public Si1[] sI { get; set; }
            public Totalpricelist1[] totalPriceList { get; set; }
        }

        public class Si1
        {
            public Fd2 fD { get; set; }
            public int stops { get; set; }
            public object[] so { get; set; }
            public int duration { get; set; }
            public Da1 da { get; set; }
            public Aa1 aa { get; set; }
            public string dt { get; set; }
            public string at { get; set; }
            public bool iand { get; set; }
            public bool isRs { get; set; }
            public int sN { get; set; }
        }

        public class Fd2
        {
            public Ai1 aI { get; set; }
            public string fN { get; set; }
            public string eT { get; set; }
        }

        public class Ai1
        {
            public string code { get; set; }
            public string name { get; set; }
            public bool isLcc { get; set; }
        }

        public class Da1
        {
            public string code { get; set; }
            public string name { get; set; }
            public string cityCode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public string terminal { get; set; }
        }

        public class Aa1
        {
            public string code { get; set; }
            public string name { get; set; }
            public string cityCode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public string terminal { get; set; }
        }

        public class Totalpricelist1
        {
            public Fd3 fd { get; set; }
            public string fareIdentifier { get; set; }
            public string id { get; set; }
            public string[] msri { get; set; }
            public string sri { get; set; }
        }

        public class Fd3
        {
            public ADULT1 ADULT { get; set; }
            public INFANT1 INFANT { get; set; }
            public CHILD1 CHILD { get; set; }
        }

        public class ADULT1
        {
            public Fc3 fC { get; set; }
            public Afc3 afC { get; set; }
            public int sR { get; set; }
            public Bi3 bI { get; set; }
            public int rT { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
            public bool mI { get; set; }
        }

        public class Fc3
        {
            public float TF { get; set; }
            public float TAF { get; set; }
            public float BF { get; set; }
            public float NF { get; set; }
            public float NCM { get; set; }
        }

        public class Afc3
        {
            public TAF3 TAF { get; set; }
            public NCM2 NCM { get; set; }
        }

        public class TAF3
        {
            public float MFT { get; set; }
            public float OT { get; set; }
            public float YQ { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float MU { get; set; }
            public float YR { get; set; }
        }

        public class NCM2
        {
            public float OT { get; set; }
            public float TDS { get; set; }
        }

        public class Bi3
        {
            public string iB { get; set; }
            public string cB { get; set; }
        }

        public class INFANT1
        {
            public Fc4 fC { get; set; }
            public Afc4 afC { get; set; }
            public Bi4 bI { get; set; }
            public int rT { get; set; }
            public bool mI { get; set; }
            public int sR { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
        }

        public class Fc4
        {
            public float TF { get; set; }
            public float TAF { get; set; }
            public float BF { get; set; }
            public float NF { get; set; }
        }

        public class Afc4
        {
            public TAF4 TAF { get; set; }
        }

        public class TAF4
        {
            public float MFT { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float YR { get; set; }
        }

        public class Bi4
        {
            public string cB { get; set; }
            public string iB { get; set; }
        }

        public class CHILD1
        {
            public Fc5 fC { get; set; }
            public Afc5 afC { get; set; }
            public int sR { get; set; }
            public Bi5 bI { get; set; }
            public int rT { get; set; }
            public string cc { get; set; }
            public string cB { get; set; }
            public string fB { get; set; }
            public bool mI { get; set; }
        }

        public class Fc5
        {
            public float TF { get; set; }
            public float TAF { get; set; }
            public float BF { get; set; }
            public float NF { get; set; }
            public float NCM { get; set; }
        }

        public class Afc5
        {
            public TAF5 TAF { get; set; }
            public NCM3 NCM { get; set; }
        }

        public class TAF5
        {
            public float MFT { get; set; }
            public float OT { get; set; }
            public float YQ { get; set; }
            public float MF { get; set; }
            public float AGST { get; set; }
            public float YR { get; set; }
        }

        public class NCM3
        {
            public float OT { get; set; }
            public float TDS { get; set; }
        }

        public class Bi5
        {
            public string iB { get; set; }
            public string cB { get; set; }
        }

        public class Status
        {
            public bool success { get; set; }
            public int httpStatus { get; set; }
        }
    }

    

}