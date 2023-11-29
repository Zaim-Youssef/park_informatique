using System;
using System.Data;
using System.Data.SqlClient;

namespace projetAnomalie
{
    public partial class liste_equipement_anomalie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // remplissage dropdown list
            if (!IsPostBack)
            {
                try
                {
                    Global.cmd.CommandText = "Select  * from UTILISATION_LOCAL ";
                    if (Global.cn.State == System.Data.ConnectionState.Open) Global.cn.Close();
                    Global.cn.Open();
                    Global.rd = Global.cmd.ExecuteReader();

                    while (Global.rd.Read())
                    {
                        DropDownList1.Items.Add(Global.rd.GetString(1));

                    }
                    Global.cn.Close();
                    Global.rd.Close();
                }
                catch (Exception ex)
                {
                    labelerror.Text = ex.Message;
                }

            }


            // label name lastname
            try
            {
                Global.cmd.CommandText = "Select  PERSONNEL.NOMPER , PERSONNEL.PRENOMPER, PERSONNEL.IDPER from PERSONNEL,UTILISATION_LOCAL  where PERSONNEL.IDPER=UTILISATION_LOCAL.IDPER and UTILISATION_LOCAL.IDLOCAL='" + DropDownList1.SelectedItem.ToString() + "'";
                if (Global.cn.State == System.Data.ConnectionState.Open) Global.cn.Close();
                Global.cn.Open();
                Global.rd = Global.cmd.ExecuteReader();

                while (Global.rd.Read())
                {
                    Label2.Text = Global.rd.GetString(0).ToString();
                    Label3.Text = Global.rd.GetString(1).ToString();
                    Session["IDPER"] = Global.rd.GetInt32(3).ToString();


                }
                Global.cn.Close();
                Global.rd.Close();
            }
            catch (Exception ex)
            {
                labelerror.Text = ex.Message;
            }

            //dgv

            try
            {
                Global.cmd.CommandText = "Select  EQUIPEMENT.IDEQP , EQUIPEMENT.NOMEQP ,EQUIPEMENT.LIEQP,EQUIPEMENT.LJEQP,EQUIPEMENT.ETATEQP ,' ' as  view_anomalie,' ' as  Create_Anomalie from EQUIPEMENT,AFFECTATION_EQUIPEMENT  where EQUIPEMENT.IDEQP=AFFECTATION_EQUIPEMENT.IDEQP and AFFECTATION_EQUIPEMENT.IDLOCAL='" + DropDownList1.SelectedItem.ToString() + "'";
                if (Global.cn.State == System.Data.ConnectionState.Open) Global.cn.Close();
                Global.cn.Open();

                DataTable dt = new DataTable();
                dt.Load(Global.cmd.ExecuteReader());
                GridView1.DataSource = dt;
                GridView1.DataBind();
                int i = 0;
                for (i = 0; i < GridView1.Rows.Count; i++)
                {
                    string checketat = GridView1.Rows[i].Cells[4].Text;
                    string idequip = GridView1.Rows[i].Cells[0].Text;
                    Session["IDEQP"] = GridView1.Rows[i].Cells[0].Text;
                    if (checketat == "marche")
                    {
                        GridView1.Rows[i].Cells[6].Text = @"<a href='creeranomalie.aspx?codeequip=" + GridView1.Rows[i].Cells[0].Text + "'  >Create</a>";
                        Label4.Visible = false;
                        GridView2.Visible = false;
                    }
                    else
                    {
                        GridView1.Rows[i].Cells[5].Text = @"<a href= >View</a>";
                        Label4.Visible = true;
                        Label4.Focus();
                        GridView2.Visible = true;
                        SqlConnection cn1 = new SqlConnection(Global.scn);
                        SqlCommand cmd1 = new SqlCommand("", cn1);
                        cmd1.CommandText = "select IDANOM,DATEANOM,DESCANOM,ETATEQPANOM ,' ' as  Edit_Anomalie,' ' as  Delete_Anomalie from ANOMALIE where IDEQP='" + idequip + "'";
                        if (cn1.State == System.Data.ConnectionState.Open) cn1.Close();
                        cn1.Open();

                        DataTable dt1 = new DataTable();
                        dt1.Load(cmd1.ExecuteReader());
                        GridView2.DataSource = dt1;
                        GridView2.DataBind();

                        int s = 0;
                        for (s = 0; s < GridView2.Rows.Count; s++)
                        {

                            GridView2.Rows[s].Cells[4].Text = @"<a href='creeranomalie.aspx?codeanomalie=" + GridView2.Rows[s].Cells[0].Text + "' >Edit</a>";
                            GridView2.Rows[s].Cells[5].Text = @"<a href='afficherdelete.aspx?codean=" + GridView2.Rows[s].Cells[0].Text + "' >Delete</a>";
                        }
                        cn1.Close();

                    }



                }
                Global.cn.Close();

            }

            catch (Exception ex)
            {
                labelerror.Text = ex.Message;
            }


        }



    }

}