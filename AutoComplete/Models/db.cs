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
                cmd.CommandText = @"select Top 10 municipality,iata_code,name from[dbo].[airportmaster] where  IATA_Code is not null and municipality LIKE '%" + Prefix + "%' or iata_code like '%" + Prefix + "%'";
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