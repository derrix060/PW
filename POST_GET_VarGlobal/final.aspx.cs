using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pw10_exemplo
{
    public partial class final : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = (String)Session["nome"];
            Label2.Text = (String)Session["idade"];            
            Response.Write(Session.SessionID);

            
        }

        protected void voltar(object sender, EventArgs e)
        {
            //redireciona a navegação
            Response.Redirect("inicio.html");
        }

        protected void logout(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}