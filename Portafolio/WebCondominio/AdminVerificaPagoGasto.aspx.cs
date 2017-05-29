using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class AdminVerificaPagoGasto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = (string)Session["Nombre"];

        }

        private Condominio.Negocio.PagoGastoComunCollection gastos = new Condominio.Negocio.PagoGastoComunCollection();



        private void CargasPagosGastos()
        {
            gastos.AnioIngresado = DateTime.Parse(ddlAnio.Text);
            gastos.MesIngresado = DateTime.Parse(ddlMes.Text);

            

            if (gastos.PagosGastosCount() != 0)
            {
                gvusuarioad.DataSource = gastos.PagosGastos();
                gvusuarioad.DataBind();
                lblMensaje.Text = "";
            }
            else
            {
                gvusuarioad.DataBind();
                lblMensaje.Text = "No se encontraron Resultados para el periodo seleccionado";
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                CargasPagosGastos();

            }
            catch (Exception)
            {

                lblMensaje.Text = "No se a Realizado la accion favor intente más tarde";
            }
        }


    }
}