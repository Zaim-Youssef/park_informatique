using System;
using System.Data.SqlClient;

namespace projetAnomalie
{
    public partial class afficherdelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                String a = Request.QueryString["codean"];
                Global.cmd.CommandText = "select ANOMALIE.IDANOM,ANOMALIE.DATEANOM,ANOMALIE.DESCANOM,EQUIPEMENT.ETATEQP from ANOMALIE,EQUIPEMENT  where  ANOMALIE.IDEQP=EQUIPEMENT.IDEQP  and ANOMALIE.IDANOM='" + a + "'"; ;
                if (Global.cn.State == System.Data.ConnectionState.Open) Global.cn.Close();
                Global.cn.Open();
                Global.rd = Global.cmd.ExecuteReader();

                while (Global.rd.Read())
                {
                    Label2.Text = Global.rd.GetInt32(0).ToString();
                    Label3.Text = Global.rd.GetDateTime(1).ToString();
                    Label4.Text = Global.rd.GetString(2).ToString();
                    Label5.Text = Global.rd.GetString(3).ToString();


                }
                Global.cn.Close();
                Global.rd.Close();
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String a = Request.QueryString["codean"];
            string query2 = "delete ANOMALIE where ='" + a + "'";

            SqlConnection cn4 = new SqlConnection(Global.scn);
            SqlCommand cmd4 = new SqlCommand("", cn4);
            cmd4.CommandText = query2;
            if (cn4.State == System.Data.ConnectionState.Open) cn4.Close();
            cn4.Open();

            if (cmd4.ExecuteNonQuery()>0)
            {

                Label6.Text = "delete non effectuer ";
            }
            else
            {
                Label6.Text = "delete effectuer";
            }
            Request.QueryString["codean"] = null;
            Global.cn.Close();

        }

    }
}
