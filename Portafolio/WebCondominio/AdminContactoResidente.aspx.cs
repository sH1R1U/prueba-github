using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;


namespace WebCondominio
{
    public partial class AdminContactoResidente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = (string)Session["Nombre"];
            lblMensajeUno.Text = (string)Session["Rspuesta"];
        }

        protected void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Session["Rspuesta"] = string.Empty;
                Consultas consulta = new Consultas();
                consulta.Id = int.Parse(ddlPendiente.Text);

                Usuario user = new Usuario();
                if (consulta.Read())
                {
                    user.Id = int.Parse(consulta.IdUser);
                    user.ReadId();
                    lblNombrePendiente.Text = user.NombreCompleto;
                    lblViviendaPendiente.Text = Convert.ToString(user.NVivienda);
                    lblConsultaPendiente.Text = consulta.Detalle;
                    lblSolucion.Text = consulta.Solucion;
                    vaciar();
                }
            }
            catch (Exception)
            {
                lblMensajeUno.Text = "A ocurrido un error Intente más tarde";
            }
        }

        protected void ConsultarSolu_Click(object sender, EventArgs e)
        {
            try
            {
                Session["Rspuesta"] = string.Empty;
                Consultas consulta = new Consultas();
                consulta.Id = int.Parse(ddlSolucion.Text);

                Usuario user = new Usuario();
                if (consulta.Read())
                {
                    user.Id = int.Parse(consulta.IdUser);
                    user.ReadId();
                    lblNombreSolucion.Text = user.NombreCompleto;
                    lblViviendaSolucion.Text = Convert.ToString(user.NVivienda);
                    lblConsultaSolucion.Text = consulta.Detalle;
                    lblSolucionS.Text = consulta.Solucion;
                    Usuario usuario = new Usuario();

                    usuario.Id = (decimal)Session["Usuario"];
                    usuario.ReadId();
                    vaciarotro();
                    lblNombreUser.Text = usuario.NombreCompleto;
                }
            }
            catch (Exception)
            {

                lblMnsaje.Text = "A ocurrido un error Intente más tarde";
            }


        }

        protected void Responder_Click(object sender, EventArgs e)
        {
            try
            {
                Session["Rspuesta"] = string.Empty;
                if (lblSolucion.Text == "" || lblSolucion.Text == null || lblSolucion.Text == "Pendiente")
                {
                    lblMensajeUno.Text = "Debe Ingresar una Respuesta";
                }
                else
                {
                    Consultas consulta = new Consultas();
                    consulta.Id = int.Parse(ddlPendiente.Text);
                    if (consulta.Read())
                    {
                        consulta.NombreAdmin = (string)Session["Nombre"];
                        consulta.Solucion = lblSolucion.Text;
                        consulta.Update();
                        vaciar();
                        Session["Rspuesta"] = "Respuesta enviada con Exito";
                        Response.Redirect("AdminContactoResidente.aspx");
                    }
                }
            }
            catch (Exception)
            {

                lblMensajeUno.Text = "A ocurrido un error Intente más tarde";
            }
        }

        public void vaciar()
        {
            lblNombreSolucion.Text = string.Empty;
            lblViviendaSolucion.Text = string.Empty;
            lblConsultaSolucion.Text = string.Empty;
            lblSolucionS.Text = string.Empty;
            lblNombreUser.Text = string.Empty;
        }

        public void vaciarotro()
        {
            lblNombrePendiente.Text = string.Empty;
            lblViviendaPendiente.Text = string.Empty;
            lblConsultaPendiente.Text = string.Empty;
            lblSolucion.Text = string.Empty;
        }
    }
}