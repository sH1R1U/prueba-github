using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class ConserConsultaPagoMultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = (string)Session["Nombre"];
            Invisible();
        }

        protected void ddlAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargasMultas();
            }
            catch (Exception)
            {
                LblMensajeMulta.Text = "No se ha encontrado registros de multas";
            }
        }

        protected void ddlMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargasMultas();
            }
            catch (Exception)
            {
                LblMensajeMulta.Text = "No se ha encontrado registros de multas";
            }
        }

        private void CargasMultas()
        {
            try
            {
                MultasCollection multa = new MultasCollection();
                multa.AnioIngresado = DateTime.Parse(ddlAnio.Text);
                multa.MesIngresado = DateTime.Parse(ddlMes.Text);
                if (multa.MultasCount() != 0)
                {
                    gvMultas.DataSource = multa.Multas();
                    gvMultas.DataBind();
                    visible();
                    LblMensajeMulta.Text = "";
                }
                else
                {
                    gvMultas.DataBind();
                    LblMensajeMulta.Text = "No se encontraron Multas Asociadas";
                }
            }
            catch (Exception)
            {

                LblMensajeMulta.Text = "No se encontraron Resultados, intente mas tarde";
            }

        }

        public void Invisible()
        {
            gvMultas.Visible = false;
            LblMensajeMulta.Text = "";
        }

        public void visible()
        {
            gvMultas.Visible = true;
        }
    }
}