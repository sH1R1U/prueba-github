using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class ResiContacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = (string)Session["Nombre"];
            vaciar();
            if (ddlSolucion.Text == "")
            {
                Combo();
            }
            
        }

        protected void Consultar_Click (object sender, EventArgs e) 
        {
            try
            {
                if (txtConsulta.Text == "")
                {
                    lblMensajeUno.Text = "Debe ingresar una consulta antes de presionar el boton";
                }
                else
                {
                    Consultas consulta = new Consultas();
                    consulta.NombreAdmin = "Pendiente";
                    consulta.Solucion = "Pendiente";
                    consulta.IdUser = Convert.ToString(Session["Usuario"]);
                    consulta.Detalle = txtConsulta.Text;
                    if (consulta.Create())
                    {
                        lblMensajeUno.Text = "Consulta Ingresada Correctamente";
                        txtConsulta.Text = "";
                    }
                    else
                    {
                        lblMensajeUno.Text = "Consulta No ha sido Ingresada";

                    }

                }

            }
            catch (Exception)
            {

                lblMensajeUno.Text = "Ha ocurrido un error al ingresar su consulta, intente mas tarde";
            }
        }

        protected void ConsultarSolu_Click(object sender, EventArgs e)
        {
            try
            {
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
                    lblNombreUser.Text = consulta.NombreAdmin;
                }
            }
            catch (Exception)
            {

                lblMnsaje.Text = "A ocurrido un error Intente más tarde";
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

        public void Combo()
        {
            try
            {
                ConsultaCollection consulta = new ConsultaCollection();
                consulta.IdUser = (decimal)Session["Usuario"];
                if (consulta.ConsultasResidentesCount() != 0)
                {
                    ddlSolucion.DataSource = consulta.ConsultasResidentes();
                    ddlSolucion.DataValueField = "Id";
                    ddlSolucion.DataBind();
                }
                else
                {
                    ddlSolucion.Items.Clear();
                    ddlSolucion.Items.Add(new ListItem { Text = "No se Han realizado consultas", Value = "" });
                }
            }
            catch (Exception)
            {

                ddlSolucion.Items.Add(new ListItem { Text = "No se Han realizado consultas", Value = "" });
            }
        }
    }
}