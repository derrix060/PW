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
    public partial class Exercicio : System.Web.UI.Page
    {
        string sc = "Server=localhost;Database=pweb;Uid=visual_studio;Pwd=visual;";
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            MySqlConnection conn = new MySqlConnection(sc);
            conn.Open();

            string sql = "SELECT * FROM cliente ORDER BY nome";
            MySqlDataAdapter conversor = new MySqlDataAdapter(sql, conn);
            conversor.Fill(ds, "tbCliente");

            sql = "SELECT * FROM livro WHERE valor < 40 ORDER BY titulo";
            conversor.SelectCommand = new MySqlCommand(sql, conn);
            conversor.Fill(ds, "tbLivro");

            conn.Close();

            gridCliente.DataSource = ds.Tables["tbCliente"];
            gridCliente.DataBind();

            dropLivro.DataSource = ds.Tables["tbLivro"];
            dropLivro.DataTextField = "titulo";
            dropLivro.DataBind();
        }
    }
}