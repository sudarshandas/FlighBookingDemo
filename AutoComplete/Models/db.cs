using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AutoComplete.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public DataSet GetAirport(string Prefix)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"select Top 10 AIRPORTMunicipality,AIRPORTIATACode,AIRPORTName,AIRPORTID from[dbo].[AIRPORTS] where AIRPORTMunicipality LIKE '%" + Prefix + "%' or AIRPORTIATACode like '%" + Prefix + "%'";
                cmd.Connection = con;
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);


                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }
    

        
    }
}