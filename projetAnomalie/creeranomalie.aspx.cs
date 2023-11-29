using System;
using System.Data.SqlClient;

namespace projetAnomalie
{
    public partial class creeranomalie : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("panne");
                DropDownList1.Items.Add("marche");


                String a = Request.QueryString["codeanomalie"];
                if (a != null)
                {
                    Global.cmd.CommandText = "select ANOMALIE.IDANOM,ANOMALIE.DATEANOM,ANOMALIE.DESCANOM,EQUIPEMENT.ETATEQP,ANOMALIE.IDEQP from ANOMALIE ,EQUIPEMENT where IDANOM='" + a + "'";

                    Global.cn.Open();
                    Global.rd = Global.cmd.ExecuteReader();


                    if (Global.rd.Read())
                    {
                        TextBox1.Text = Global.rd.GetInt32(0).ToString();
                        TextBox2.Text = Global.rd.GetDateTime(1).ToString();
                        TextBox3.Text = Global.rd.GetString(2).ToString();
                        Session["ideq"] = Global.rd.GetString(4).ToString();

                        Label2.Text = (string)Session["ideq"];
                        Button1.Visible = false;
                    }
                    Global.cn.Close();
                    Global.rd.Close();
                }
                else{

                        Button3.Visible = false;
                        Button1.Visible = true;
                }
                

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //// remplissage part 1 update 1

            string query = "update  ANOMALIE  set DATEANOM ='" + DateTime.Parse(TextBox2.Text) + "',DESCANOM='" + TextBox3.Text + "' where IDEQP='" + Session["ideq"] + "'";
            string query1 = "update EQUIPEMENT set ETATEQP ='" + DropDownList1.Text + "' where IDEQP='" + Session["ideq"] + "'";

            SqlConnection cn3 = new SqlConnection(Global.scn);
            SqlCommand cmd3 = new SqlCommand("", cn3);
            cmd3.CommandText = query;
            if (cn3.State == System.Data.ConnectionState.Open) cn3.Close();
            cn3.Open();



            if (cmd3.ExecuteNonQuery() > 0)
            {
                Label2.Text = "modification effectuer";

            }
            else
            {
                Label2.Text = "non modification effectuer";
            }
            Global.cn.Close();
            //// remplissage part 2 update 1
            ///

            cmd3.CommandText = query1;
            if (cn3.State == System.Data.ConnectionState.Open) cn3.Close();
            cn3.Open();



            if (cmd3.ExecuteNonQuery() > 0)
            {
                Label2.Text = "modification part 2 effectuer";
                

            }
            else
            {
                Label2.Text = " modification part 2 non effectuer";
            }
            cn3.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string queryi = "insert into ANOMALIE(IDANOM, DATEANOM, DESCANOM,IDEQP,IDPER) values('" + int.Parse(TextBox1.Text) + "', '" + DateTime.Parse(TextBox2.Text) + "', '" + TextBox3.Text+ "','" + Session["IDEQP"] + "','" + Session["IDPER"] + "')";
            string queryi1 = "update EQUIPEMENT set ETATEQP ='" + DropDownList1.Text + "' where IDEQP='" + Session["IDEQP"] + "'";
            SqlConnection cn3 = new SqlConnection(Global.scn);
            SqlCommand cmd3 = new SqlCommand("", cn3);
            cmd3.CommandText = queryi;
            if (cn3.State == System.Data.ConnectionState.Open) cn3.Close();
            cn3.Open();



            if (cmd3.ExecuteNonQuery() > 0)
            {
                Label2.Text = "ins effectuer";

            }
            else
            {
                Label2.Text = "non ins effectuer";
            }
            Global.cn.Close();
           
              //// remplissage part 2 update 1 ajout
            ///

            cmd3.CommandText = queryi1;
            if (cn3.State == System.Data.ConnectionState.Open) cn3.Close();
            cn3.Open();



            if (cmd3.ExecuteNonQuery() > 0)
            {
                Label2.Text = "modification  ins part 2 effectuer";


            }
            else
            {
                Label2.Text = " modification ins part 2 non effectuer";
            }
            cn3.Close();

        }
    }
}