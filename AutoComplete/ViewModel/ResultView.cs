using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoComplete.Models;

namespace AutoComplete.ViewModel
{
    public class ResultView
    {

        public OnewayDomesticSearchQuery.RootObject onewayDomsticSaerch { get; set; }
        // public OnewayDomesticResult.Rootobject onewayDomesticResult { get; set; }
        public string airlineName { get; set; }
        public string depatureCity { get; set; }
        public string depatureTime { get; set; }
        public string duration { get; set; }
        public string viaCity { get; set; }
        public string arrivalCity { get; set; }
        public string arrivalTime { get; set; }
        float adultPrice, childPrice, infantPrice;
        double TotalPrice;
        int adultPerson, childPerson, infantPerson;
        public List<int> CalPrice(List<OnewayDomesticResult.Rootobject> result, OnewayDomesticSearchQuery.RootObject result1)
        {
            List<int> Price=new List<int>();
            //{
            //get
            //{
            //    return Convert.ToInt32(TotalPrice);
            //}
            //set
            //{
            foreach (var onewayDomesticResult in result)
            {
                foreach (var onward in onewayDomesticResult.searchResult.tripInfos.ONWARD)
                {
                    foreach (var pricelists in onward.totalPriceList)
                    {
                        if (pricelists.fd.ADULT.fC.NF.ToString() != null)
                        {
                            adultPrice = pricelists.fd.ADULT.fC.NF;
                            adultPerson = Convert.ToInt32(result1.searchQuery.paxInfo.ADULT);
                        }
                        if (pricelists.fd.CHILD != null)
                        {
                            childPrice = pricelists.fd.CHILD.fC.NF;
                            childPerson = Convert.ToInt32(result1.searchQuery.paxInfo.CHILD);
                        }
                        if (pricelists.fd.INFANT != null)
                        {
                            infantPrice = pricelists.fd.INFANT.fC.NF;
                            infantPerson = Convert.ToInt32(result1.searchQuery.paxInfo.INFANT);
                        }
                        
                        
                        
                        TotalPrice = (adultPrice * adultPerson) + (childPrice * childPerson) + (infantPrice * infantPerson);
                        Price.Add(Convert.ToInt32(TotalPrice));
                    }
                }
            }
            //}
            //}
            return Price;
        }

    }
    
}