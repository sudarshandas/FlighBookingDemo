using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoComplete.Models;

namespace AutoComplete.ViewModel
{
    public class ResultView
    {
        public Tripinfos tripInfos { get; set; }
        public Status status { get; set; }
    }
    public class Tripinfos
    {
        public ONEWAY[] oneway { get; set; }
    }

    public class ONEWAY
    {
        public SegmentInfo[] segmentInfo { get; set; }
        public Totalpricelist[] totalPriceList { get; set; }
    }

    public class SegmentInfo
    {
        public FlightDetails flightDetails { get; set; }
        public int stops { get; set; }
        public So[] so { get; set; }
        public int duration { get; set; }
        public DepatureInformation depatureInformation { get; set; }
        public ArrivalInformation arrivalInformation { get; set; }
        public string depatureTime { get; set; }
        public string depatureDate { get; set; }
        public string depatureDateName { get; set; }
        public string arrivalTime { get; set; }
        public string arrivalDate { get; set; }
        public string arrivalDateName { get; set; }
    }

    public class FlightDetails
    {
        public AirlineInfo airlineInfo { get; set; }
        public string flightNumber { get; set; }
        public string equipmentType { get; set; }
    }

    public class AirlineInfo
    {
        public string airlineCode { get; set; }
        public string airlineName { get; set; }
    }

    public class DepatureInformation
    {
        public string iataCode { get; set; }
        public string airportName { get; set; }
        public string cityCode { get; set; }
        public string cityName { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string terminal { get; set; }
    }

    public class ArrivalInformation
    {
        public string iataCode { get; set; }
        public string airportName { get; set; }
        public string cityCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string terminal { get; set; }
    }


    public class So
    {
        public string code { get; set; }
        public string name { get; set; }
        public string cityCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
    }

    public class Totalpricelist
    {
        public FareDetails fareDetails { get; set; }
        public string fareName { get; set; }
        public string fareId { get; set; }
        public object[] fareMessages { get; set; }
    }

    public class FareDetails
    {
        public ADULT ADULT { get; set; }
        public CHILD CHILD { get; set; }
        public INFANT INFANT { get; set; }
    }
    public class CHILD
    {
        public ChildFareComponent cFC { get; set; }

        public ChildBaggageInformation cBI { get; set; }
        public int refundableType { get; set; }
        public string cabinClass { get; set; }
        public string classOfBooking { get; set; }
        public string fareBasis { get; set; }
        public bool mealIndicator { get; set; }
        public int seatsRemaining { get; set; }
    }
    public class ChildFareComponent
    {

        public float basicFareCharge { get; set; }
        public float totalFareCharge { get; set; }

    }
    public class ChildBaggageInformation
    {
        public string checkingBaggage { get; set; }
        public string cabinBaggage { get; set; }
    }
    public class ADULT
    {
        public AdultFareComponent aFC { get; set; }
        public AdultBaggageInformation aBI { get; set; }
        public int refundableType { get; set; }
        public string cabinClass { get; set; }
        public string classOfBooking { get; set; }
        public string fareBasis { get; set; }
        public bool mealIndicator { get; set; }
        public int seatsRemaining { get; set; }


    }

    public class AdultFareComponent
    {
        public float basicFareCharge { get; set; }
        public float totalFareCharge { get; set; }

    }
    public class AdultBaggageInformation
    {
        public string checkingBaggage { get; set; }
        public string cabinBaggage { get; set; }
    }

    public class Status
    {
        public bool success { get; set; }
        public int httpStatus { get; set; }
    }
    public class INFANT
    {
        public InfantFareComponent iFC { get; set; }

        public InfantBaggageInformation iBI { get; set; }
        public int refundableType { get; set; }
        public string cabinClass { get; set; }
        public string classOfBooking { get; set; }
        public string fareBasis { get; set; }
        public bool mealIndicator { get; set; }
        public int seatsRemaining { get; set; }
    }

    public class InfantFareComponent
    {
        public float basicFareCharge { get; set; }
        public float totalFareCharge { get; set; }

    }

    public class InfantBaggageInformation
    {
        public string checkingBaggage { get; set; }
        public string cabinBaggage { get; set; }
    }
}