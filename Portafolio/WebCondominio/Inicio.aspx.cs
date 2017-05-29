using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
          
            if (txtContrasena.Text == "" || txtNombre.Text == "")
            {
                if (txtContrasena.Text == "" && txtNombre.Text != "")
                {
                    lblMensaje.Text = "Contraseña Es Requerido";
                }
                else if (txtContrasena.Text != "" && txtNombre.Text == "")
                {
                    lblMensaje.Text = "Usuario es Requerido";
                }
                else
                {
                    lblMensaje.Text = "Usuario y  Contraseña Son Requeridos";
                }
            }
            else
            {
                Usuario user = new Usuario
                {
                    NombreUser = txtNombre.Text,
                    Contrasena = txtContrasena.Text

                };

                if (user.ValidarUsuario())
                {
                    if (user.Read())
                    {
                        if (user.Estado == "2")
                        {
                            Session["NombreUser"] = user.NombreUser;
                            txtNombre.Text = string.Empty;
                            txtContrasena.Text = string.Empty;
                            lblMensaje.Text = "Usuario " + user.NombreUser + " se encuentra DesHabilitado";
                        }
                        else
                        {
                            Session["Usuario"] = user.Id;
                            Session["Autentica"] = user.Login;
                            Session["Nombre"] = user.NombreCompleto;
                            Session["NombreUser"] = user.NombreUser;
                            FormsAuthentication.RedirectFromLoginPage(txtNombre.Text, false);
                        }

                    }
                    else
                    {
                        Session["Usuario"] = null;
                        Session["Autentica"] = null;
                        Session["Nombre"] = null;
                        txtNombre.Text = string.Empty;
                        txtContrasena.Text = string.Empty;
                        lblMensaje.Text = "Error al Iniciar Sesion Comuniquese con el Administrador";
                    }

                }
                else
                {
                    lblMensaje.Text = "Usuario o Contraseña no son Correctos";
                }
            }

        }
    }
}
