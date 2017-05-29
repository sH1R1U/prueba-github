using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCondominio
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["Autentica"] == "1")
            {
                Response.Redirect("Administrador.aspx");
            }
            else if ((string)Session["Autentica"] == "4")
            {
                Response.Redirect("Residente.aspx");
            }
            else if ((string)Session["Autentica"] == "2")
            {
                Response.Redirect("Directiva.aspx");
            }
            else if ((string)Session["Autentica"] == "3")
            {
                Response.Redirect("Conserje.aspx");
            }
            else if ((string)Session["Autentica"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}