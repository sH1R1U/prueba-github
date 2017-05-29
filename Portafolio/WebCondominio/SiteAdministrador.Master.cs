using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCondominio
{
    public partial class SiteAdministrador : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["Rspuesta"] = string.Empty;
 
            if ((string)Session["Nombre"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
            if ((string)Session["Autentica"] == "1")
            {

            }
            else if ((string)Session["Autentica"] == "4")
            {
                Response.Redirect("Residente.aspx");
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