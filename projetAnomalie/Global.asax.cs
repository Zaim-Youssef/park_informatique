using System;
using System.Data.SqlClient;


namespace projetAnomalie
{
    public class Global : System.Web.HttpApplication
    {

        public static string scn = @"Data source=.\sqlexpress;initial catalog=dbEquipement; integrated security=true";
        public static SqlConnection cn = new SqlConnection(scn);
        public static SqlCommand cmd = new SqlCommand("", cn);
        public static SqlDataReader rd;


        protected void Application_Start(object sender, EventArgs e)
        {


        }
    }
}