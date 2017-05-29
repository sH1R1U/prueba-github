using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class ResiPagarGasto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = (string)Session["Nombre"];

            Invisible();

        }

        private Condominio.Negocio.PagoGastoComunCollection gastos = new Condominio.Negocio.PagoGastoComunCollection();


        protected void ddlAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gastos.AnioIngresado = DateTime.Parse(ddlAnio.Text);
                gastos.MesIngresado = DateTime.Parse(ddlMes.Text);
                gastos.NombreUser = (string)Session["NombreUser"];
                if (gastos.PagosGastosPendientesPagarCount() != 0)
                {
                    ddlGasto.DataSource = gastos.PagosGastosPendientesPagar();
                    ddlGasto.DataTextField = "FechaGasto";
                    ddlGasto.DataValueField = "Id";
                    ddlGasto.DataBind();
                }
                else
                {
                    ddlGasto.Items.Clear();
                    ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Registros" });
                    lblMensaje.Text = "No Se Encontraron Pagos Pendientes para el periodo seleccionado o su cuenta se encuentra Pagada";
                }
            }
            catch (Exception)
            {
                ddlGasto.Items.Clear();
                ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Registros" });
            }
        }

        protected void ddlMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gastos.AnioIngresado = DateTime.Parse(ddlAnio.Text);
                gastos.MesIngresado = DateTime.Parse(ddlMes.Text);
                gastos.NombreUser = (string)Session["NombreUser"];
                if (gastos.PagosGastosPendientesPagarCount() != 0)
                {
                    ddlGasto.DataSource = gastos.PagosGastosPendientesPagar();
                    ddlGasto.DataTextField = "FechaGasto";
                    ddlGasto.DataValueField = "Id";
                    ddlGasto.DataBind();
                }
                else
                {
                    ddlGasto.Items.Clear();
                    ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Gastos No Pagados", Value = "" });
                }
            }
            catch (Exception)
            {

                ddlGasto.Items.Clear();
                ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Gastos No Pagados", Value = "" });
            }
        }


        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                CargasGastos();
                CargasMultas();
                CargasPagosGastos();
                visible();

            }
            catch (Exception)
            {

                lblMensaje.Text = "No se a Realizado la accion favor intente más tarde";
            }
        }

        private void CargasMultas()
        {
            try
            {
                MultasCollection multa = new MultasCollection();
                multa.IdpagoGas = int.Parse(ddlGasto.Text);
                if (multa.MultasCountPagarResidente() != 0)
                {
                    gvMultas.DataSource = multa.MultasPagarResidentes();
                    gvMultas.DataBind();
                    lblMensaje.Text = "";
                }
                else
                {
                    gvMultas.DataBind();
                    LblMensajeMulta.Text = "No se encontraron Multas NO Pagadas para el periodo seleccionado";
                }
            }
            catch (Exception)
            {

                LblMensajeMulta.Text = "No se encontraron Resultados, intente mas tarde";
            }

        }

        private void CargasGastos()
        {
            try
            {
                if (ddlGasto.Text != "")
                {
                    DetatalleGastosComunesCollection detgas = new DetatalleGastosComunesCollection();
                    detgas.IdpagoGas = int.Parse(ddlGasto.Text);
                    if (detgas.DetalleGastosPagarCount() != 0)
                    {
                        gvusuarioad.DataSource = detgas.DetallePagarGastos();
                        gvusuarioad.DataBind();
                        lblMensaje.Text = "";
                        btnPagarGasto.Visible = true;
                    }
                    else
                    {
                        gvusuarioad.DataBind();
                        lblMensaje.Text = "No se encontraron Gastos Comunes NO Pagados para el periodo seleccionado";
                    }
                }
                else
                {
                    lblMensaje.Text = "se debe seleccionar una fecha valida";
                }

            }
            catch (Exception)
            {

                lblMensaje.Text = "No se encontraron Resultados, intente mas tarde";
            }


        }

        private void CargasPagosGastos()
        {
            gastos.IdPagoGasto = int.Parse(ddlGasto.Text);
            if (gastos.PagosGastosParaPagarCount() != 0)
            {
                gvusuario.DataSource = gastos.PagosGastosParaPagar();
                gvusuario.DataBind();
                lblPagoGasto.Text = "";
            }
            else
            {
                gvusuario.DataBind();
                lblPagoGasto.Text = "No se encontraron Pagos Pendientes para el periodo seleccionado";
            }
        }

        public void Invisible()
        {
            gvMultas.Visible = false;
            gvusuarioad.Visible = false;
            gvusuario.Visible = false;
            lblMensa.Text = "";
            lblMensaje.Text = "";
            LblMensajeMulta.Text = "";
            lblPagoGasto.Text = "";
            btnPagarGasto.Visible = false;
        }

        public void visible()
        {
            gvMultas.Visible = true;
            gvusuarioad.Visible = true;
            gvusuario.Visible = true;
            btnPagarGasto.Visible = true;
        }

    }
}