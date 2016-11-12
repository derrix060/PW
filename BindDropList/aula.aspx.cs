using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//DataSet
using System.Data;

//banco
using MySql.Data.MySqlClient;

namespace BindDropList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string sc = "Server=localhost;Database=pweb;Uid=visual_studio;Pwd=visual;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Carregar(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            MySqlConnection conn = new MySqlConnection(sc);
            conn.Open();

            string sql = "SELECT * FROM produto ORDER BY nome";
            MySqlDataAdapter conversor = new MySqlDataAdapter(sql, conn);
            conversor.Fill(ds, "tbCliente");

            sql = "SELECT * FROM produto WHERE valor < 40 ORDER BY valor DESC";
            conversor.SelectCommand = new MySqlCommand(sql, conn);
            conversor.Fill(ds, "tbPromo");

            conn.Close();

            CheckBoxList1.DataSource = ds.Tables["tbCliente"];
            CheckBoxList1.DataTextField = "nome";
            CheckBoxList1.DataBind();

            GridView1.DataSource = ds.Tables["tbCliente"];
            GridView1.DataBind();

            DropDownList1.DataSource = ds.Tables["tbPromo"];
            DropDownList1.DataTextField = "valor";
            DropDownList1.DataBind();


        }
        
    }
}