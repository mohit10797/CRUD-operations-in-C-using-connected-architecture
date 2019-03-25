using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Address_Book_Connected_Architecture_
{
    public partial class Main : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        public int flag = 0;
        public void search(SqlConnection con)
        {
            con.Open();
            com = new SqlCommand("Select * from Address_Book", con);
            
            using (SqlDataReader read = com.ExecuteReader())
            {
                
                while (read.Read())
                {
                    Textid.Value = Convert.ToString(read["Address_id"]);
                    Textfname.Text = Convert.ToString(read["First_Name"]);
                    Textlname.Text = Convert.ToString(read["Last_Name"]);
                    Textemail.Text = Convert.ToString(read["Email"]);
                    Textphone.Text = Convert.ToString(read["Phone"]);
                }
            }
            con.Close();
        }
        public SqlConnection create_connection()
        {
            return new SqlConnection("data source=FREYA;initial catalog=gic;integrated security=true");
        }

        String Connection = "data source=FREYA;initial catalog=gic;integrated security=true";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = create_connection())
                {
                    com = new SqlCommand("insert_address", con);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", Convert.ToInt16(Textid.Value));
                    com.Parameters.AddWithValue("@fname", Textfname.Text);
                    com.Parameters.AddWithValue("@lname", Textlname.Text);
                    com.Parameters.AddWithValue("@email", Textemail.Text);
                    com.Parameters.AddWithValue("@phone", Textphone.Text);
                    SqlParameter returnParameter = com.Parameters.Add("RetVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    con.Open();
                    com.ExecuteNonQuery();
                    flag = (int)returnParameter.Value;
                    if (flag == 1)
                    {
                        Label1.Text = "Record Inserted";
                    }
                    else
                    {
                        Label1.Text = "Unable to insert Record";
                    }
                    con.Close();
                }
            }catch(Exception ex) { }

        }

        protected void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = create_connection())
                {
                    com = new SqlCommand("update_email", con);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", Convert.ToInt16(Textid.Value));
                    com.Parameters.AddWithValue("@email", Textemail.Text);
                    SqlParameter returnParameter = com.Parameters.Add("RetVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    con.Open();
                    com.ExecuteNonQuery();
                    flag = (int)returnParameter.Value;
                    if (flag == 1)
                    {
                        Label1.Text = "Email Updated";
                    }
                    else
                    {
                        Label1.Text = "Unable to Update Record";
                    }
                    con.Close();
                }
            }
            catch(Exception ex) { }
        }

        protected void Find_lastname_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = create_connection())
                {
                    com = new SqlCommand("Select * from Address_Book where Last_Name = @lname", con);
                    com.Parameters.AddWithValue("@lname", Textlname.Text);
                    con.Open();
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        Textid.Value = Convert.ToString(read["Address_id"]);
                        Textfname.Text = Convert.ToString(read["First_Name"]);
                        Textlname.Text = Convert.ToString(read["Last_Name"]);
                        Textemail.Text = Convert.ToString(read["Email"]);
                        Textphone.Text = Convert.ToString(read["Phone"]);
                    }
                    con.Close();
                }
            }catch(Exception ex) { }
        }

        protected void Browse_all_enteries_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = create_connection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Address_Book", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {


                using (con = create_connection())
                {
                    com = new SqlCommand("delete_address", con);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", Convert.ToInt16(Textid.Value));
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }catch(Exception ex) { }
        }

        protected void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = create_connection())
                {
                    search(con);
                }
            }catch(Exception ex) { }
        }
    } }