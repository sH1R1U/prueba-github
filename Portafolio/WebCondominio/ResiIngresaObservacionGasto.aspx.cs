using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class ResiIngresaObservacionGasto : System.Web.UI.Page
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
                if (gastos.PagosGastosPendienCount() != 0)
                {
                    ddlGasto.DataSource = gastos.PagosGastosPendien();
                    ddlGasto.DataTextField = "FechaGasto";
                    ddlGasto.DataValueField = "Id";
                    ddlGasto.DataBind();
                }
                else
                {
                    ddlGasto.Items.Clear();
                    ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Registros" });
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
                if (gastos.PagosGastosPendienCount() != 0)
                {
                    ddlGasto.DataSource = gastos.PagosGastosPendien();
                    ddlGasto.DataTextField = "FechaGasto";
                    ddlGasto.DataValueField = "Id";
                    ddlGasto.DataBind();
                }
                else
                {
                    ddlGasto.Items.Clear();
                    ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Registros", Value = "" });
                }
            }
            catch (Exception)
            {

                ddlGasto.Items.Clear();
                ddlGasto.Items.Add(new ListItem { Text = "No Se Encontraron Registros", Value = "" });
            }
        }


        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                CargasGastos();
                CargasMultas();
                visible();

                DetalleGastosComunes det = new DetalleGastosComunes();
                det.IdPago = decimal.Parse(ddlGasto.Text);
                det.Read();
                if (det.Observacion != null)
                {
                    txtObservacion.Text = det.Observacion;
                    txtObservacion.Enabled = false;
                }
                else
                {
                    txtObservacion.Text = "";
                    txtObservacion.Enabled = true;
                }

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
                if (multa.MultasCountResidente() != 0)
                {
                    gvMultas.DataSource = multa.MultasResidentes();
                    gvMultas.DataBind();
                    lblMensaje.Text = "";
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

        private void CargasGastos()
        {
            try
            {
                if (ddlGasto.Text != "")
                {
                    DetatalleGastosComunesCollection detgas = new DetatalleGastosComunesCollection();
                    detgas.IdpagoGas = int.Parse(ddlGasto.Text);
                    if (detgas.DetalleGastosCount() != 0)
                    {
                        gvusuarioad.DataSource = detgas.DetalleGastos();
                        gvusuarioad.DataBind();
                        lblMensaje.Text = "";
                        txtObservacion.Visible = true;
                        btnActualizarobservacion.Visible = true;
                    }
                    else
                    {
                        gvusuarioad.DataBind();
                        lblMensaje.Text = "No se encontraron Resultados";
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

        protected void btnActualizarobservacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtObservacion.Enabled == false)
                {
                    lblMensa.Text = "No solo se puede enviar observacion una vez";
                }
                else
                {
                    DetalleGastosComunes detgas = new DetalleGastosComunes();
                    detgas.IdPago = decimal.Parse(ddlGasto.Text);
                    detgas.Observacion = txtObservacion.Text;
                    detgas.Update();

                    MultasCollection multa = new MultasCollection();
                    if (multa.MultasCountResidente() != 0)
                    {
                        Multas multas = new Multas();
                        detgas.IdPago = decimal.Parse(ddlGasto.Text);
                        multas.Observacion = txtObservacion.Text;
                        multas.Update();
                        txtObservacion.Text = "";
                    }
                    lblMensa.Text = "Observacion ingresada Correctamente";
                }

            }
            catch (Exception)
            {

                lblMensa.Text = "Error al ingresar la observacion";
            }
        }

        public void Invisible()
        {
            gvMultas.Visible = false;
            gvusuarioad.Visible = false;
            lblMensa.Text = "";
            lblMensaje.Text = "";
            LblMensajeMulta.Text = "";
            txtObservacion.Visible = false;
            btnActualizarobservacion.Visible = false;
        }

        public void visible()
        {
            gvMultas.Visible = true;
            gvusuarioad.Visible = true;
            txtObservacion.Visible = true;
            btnActualizarobservacion.Visible = true;
        }

    }
}