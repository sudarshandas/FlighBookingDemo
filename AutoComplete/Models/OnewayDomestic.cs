using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoComplete.Models
{
    public class OnewayDomestic
    {
    }
    public  class Item
    {
        public IEnumerable<Searchresult> rootObj { get; set; }
        
    }
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
        public ONWARD[] ONWARD { get; set; }
    }

    public class ONWARD
    {
        public Si[] sI { get; set; }
        public Totalpricelist[] totalPriceList { get; set; }
    }

    public class Si
    {
        public Fd fD { get; set; }
        public int stops { get; set; }
        public int duration { get; set; }
        public Da da { get; set; }
        public Aa aa { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public string dt { get; set; }
        public string at { get; set; }
        public bool iand { get; set; }
        public bool isRs { get; set; }
        public int sN { get; set; }
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

    public class Totalpricelist
    {
        public Fd1 fd { get; set; }
        public string fareIdentifier { get; set; }
        public string id { get; set; }
        public object[] msri { get; set; }
    }

    public class Fd1
    {
        public CHILD CHILD { get; set; }
        public INFANT INFANT { get; set; }
        public ADULT ADULT { get; set; }
    }

    public class CHILD
    {
        public Fc fC { get; set; }
        public Afc afC { get; set; }
        public int sR { get; set; }
        public Bi bI { get; set; }
        public int rT { get; set; }
        public string cc { get; set; }
        public string cB { get; set; }
        public string fB { get; set; }
    }

    public class Fc
    {
        public float NF { get; set; }
        public float TAF { get; set; }
        public float TF { get; set; }
        public float BF { get; set; }
    }

    public class Afc
    {
        public TAF TAF { get; set; }
    }

    public class TAF
    {
        public float MF { get; set; }
        public float OT { get; set; }
        public float YR { get; set; }
        public float MFT { get; set; }
        public float AGST { get; set; }
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
        public int sR { get; set; }
        public Bi1 bI { get; set; }
        public int rT { get; set; }
        public string cc { get; set; }
        public string cB { get; set; }
        public string fB { get; set; }
    }

    public class Fc1
    {
        public float NF { get; set; }
        public float TAF { get; set; }
        public float TF { get; set; }
        public float BF { get; set; }
    }

    public class Afc1
    {
        public TAF1 TAF { get; set; }
    }

    public class TAF1
    {
        public float MF { get; set; }
        public float YR { get; set; }
        public float MFT { get; set; }
        public float AGST { get; set; }
    }

    public class Bi1
    {
        public string iB { get; set; }
        public string cB { get; set; }
    }

    public class ADULT
    {
        public Fc2 fC { get; set; }
        public Afc2 afC { get; set; }
        public int sR { get; set; }
        public Bi2 bI { get; set; }
        public int rT { get; set; }
        public string cc { get; set; }
        public string cB { get; set; }
        public string fB { get; set; }
    }

    public class Fc2
    {
        public float NF { get; set; }
        public float TAF { get; set; }
        public float TF { get; set; }
        public float BF { get; set; }
    }

    public class Afc2
    {
        public TAF2 TAF { get; set; }
    }

    public class TAF2
    {
        public float MF { get; set; }
        public float OT { get; set; }
        public float YR { get; set; }
        public float MFT { get; set; }
        public float AGST { get; set; }
    }

    public class Bi2
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