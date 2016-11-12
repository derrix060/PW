using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Database
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace CrudLivro
{
    public partial class livro : System.Web.UI.Page
    {
        string strConn = "Server=localhost;Database=pweb;uid=root;pwd=;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                String sql = "INSERT INTO livro (titulo, autor, qtd, valor, paginas, resumo) VALUES "
                    + "('" + txtTitulo + "','" + txtAutor + "'," + txtQtde + "," + txtValor + "," + txtPaginas + ",'" + txtResumo + "')";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();
                lblMensagem.Text = "Registro inserido com sucesso!";

                conn.Close();
                clean();
                lblMensagem.Text = "Comando executado com sucesso!";
            }
            catch
            {
                lblMensagem.Text = "Ocorreu um erro!";
            }
        }

        private void clean()
        {
            txtAutor.Text = "";
            txtCodigo.Text = "";
            txtPaginas.Text = "";
            txtQtde.Text = "";
            txtResumo.Text = "";
            txtTitulo.Text = "";
            txtValor.Text = "";
        }

        protected void Read(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                string sql = "SELECT * FROM livro WHERE codigo = " + txtCodigo.Text;

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader dtReader =  command.ExecuteReader();

                if (dtReader.Read())
                {
                    txtAutor.Text = dtReader["autor"].ToString();
                    txtPaginas.Text = dtReader["paginas"].ToString();
                    txtQtde.Text = dtReader["qtd"].ToString();
                    txtResumo.Text = dtReader["resumo"].ToString();
                    txtTitulo.Text = dtReader["titulo"].ToString();
                    txtValor.Text = dtReader["valor"].ToString();
                }
                else
                {
                    lblMensagem.Text = "Ocorreu um erro!";
                }


                conn.Close();
            }
            catch
            {

            }
        }

        protected void Update(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                string sql = "UPDATE livro SET "
                    + "titulo = '" + txtTitulo + "', "
                    + "autor = '" + txtAutor + "', "
                    + "qtd = " + txtQtde + ", "
                    + "valor = " + txtValor + ", "
                    + "paginas = " + txtPaginas + ", "
                    + "resumo = '" + txtResumo + "' "
                    + "WHERE codigo = " + txtCodigo;

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();

                conn.Close();
                clean();
                lblMensagem.Text = "Comando executado com sucesso!";
            }
            catch
            {
                lblMensagem.Text = "Ocorreu um erro!";
            }
        }

        protected void clean(object sender, EventArgs e)
        {
            clean();
        }

        protected void Delete(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                string sql = "DELETE FROM livro WHERE codigo = " + txtCodigo.Text;
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();

                conn.Close();
                clean();
                lblMensagem.Text = "Comando executado com sucesso!";
            }
            catch
            {
                lblMensagem.Text = "Ocorreu um erro!";
            }
        }
    }
}