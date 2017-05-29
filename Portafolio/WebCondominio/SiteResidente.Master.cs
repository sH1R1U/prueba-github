using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebCondominio
{
    public partial class SiteResidente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["Nombre"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
            //lblUsuario.Text = (string)Session["Nombre"];

            if ((string)Session["Estado"] == "2")
            {
                Response.Redirect("Inicio.aspx", (string)Session["Mensaje"] == "Estimado " + (string)Session["Nombre"]+ " su cuenta se encuentra Bloqueada");
            }

            if ((string)Session["Autentica"] == "1")
            {
                Response.Redirect("Administrador.aspx");
            }

            else if ((string)Session["Autentica"] == "4")
            {
                
            }
            else if ((string)Session["Autentica"] == "3")
            {
                Response.Redirect("Directiva.aspx");
            }
            else if ((string)Session["Autentica"] == "2")
            {
                Response.Redirect("Conserje.aspx");
            }
            else if ((string)Session["Autentica"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void CerrarSession_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Inicio.aspx");
        }
    }
}