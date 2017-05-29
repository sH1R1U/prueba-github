using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class Conserje : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            //Perfil();
             lblNombre.Text = (string)Session["Nombre"];
        }

        /*protected void Perfil()
        {
            {
                try
                {
                    Usuario usu = new Usuario();
                    usu.Id = int.Parse(Convert.ToString(Session["Usuario"]));

                    if (usu.Perfil())
                    {
                        lblNombre.Text = usu.NombreCompleto;
                        lblRut.Text = usu.Rut;
                        lblTelefono.Text = usu.Telefono;
                        lblNombreUser.Text = usu.NombreUser;
                        lblPrivilegios.Text = Convert.ToString(usu.Login);
                        lblEmail.Text = usu.Correo;
                    }
                }
                catch
                {
                    lblPerfil.Text = "No se necontro la infomracion del Usuario";

                }

            }
        }*/

    }
}
    

