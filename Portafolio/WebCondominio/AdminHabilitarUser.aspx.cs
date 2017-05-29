using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Condominio.Negocio;

namespace WebCondominio
{
    public partial class AdminHabilitarUser : System.Web.UI.Page
    {
        private Condominio.Negocio.UsuarioCollection usuario = new Condominio.Negocio.UsuarioCollection();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = (string)Session["Nombre"];
            CargasUsuariosAd();
            CargasUsuariosRe();
            CargasUsuariosCo();
            CargasUsuariosDi();
        }

        private void CargasUsuariosAd()
        {

            gvusuarioad.DataSource = usuario.UsuariosAdministrador();
            gvusuarioad.DataBind();
        }

        private void CargasUsuariosRe()
        {

            gvResidente.DataSource = usuario.UsuariosResidentes();
            gvResidente.DataBind();
        }

        private void CargasUsuariosCo()
        {

            gvConserje.DataSource = usuario.UsuariosConserje();
            gvConserje.DataBind();
        }

        private void CargasUsuariosDi()
        {

            gvDirectiva.DataSource = usuario.UsuariosDirectiva();
            gvDirectiva.DataBind();
        }


        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlUserAdmin.Text;

                if (usu.Read())
                {

                    ddlEstado.Text = Convert.ToString(usu.Estado);

                    lblMensaje.Text = string.Empty;
                }
                else
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Error al leer Usuario";

            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlUserAdmin.Text;

                if (usu.Read())
                {
                    usu.Estado = ddlEstado.Text;
                    usu.Update();
                    CargasUsuariosAd();
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    lblMenDirec.Text = string.Empty;
                    lblMenResi.Text = string.Empty;
                    lblMenCon.Text = string.Empty;
                    lblMensaje.Text = "Usuario Actualizado";
                }
                else
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Usuario al actualizar Encargado";

            }
        }

        protected void btnConsCon_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlUserAdmin.Text;

                if (usu.Read())
                {

                    ddlConEs.Text = Convert.ToString(usu.Estado);

                    lblMensaje.Text = string.Empty;
                }
                else
                {
                    lblMenCon.ForeColor = System.Drawing.Color.Red;
                    lblMenCon.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMenCon.ForeColor = System.Drawing.Color.Red;
                lblMenCon.Text = "Error al leer Usuario";

            }
        }

        protected void btnEditCon_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlConserje.Text;

                if (usu.Read())
                {
                    usu.Estado = ddlConEs.Text;
                    usu.Update();
                    CargasUsuariosCo();
                    lblMenCon.ForeColor = System.Drawing.Color.Green;
                    lblMenDirec.Text = string.Empty;
                    lblMenResi.Text = string.Empty;
                    lblMensaje.Text = string.Empty;
                    lblMenCon.Text = "Usuario Actualizado";
                }
                else
                {
                    lblMenCon.ForeColor = System.Drawing.Color.Red;
                    lblMenCon.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMenCon.ForeColor = System.Drawing.Color.Red;
                lblMenCon.Text = "Usuario al actualizar Encargado";

            }
        }

        protected void btnConsulDi_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlConDi.Text;

                if (usu.Read())
                {

                    ddlEditDi.Text = Convert.ToString(usu.Estado);

                    lblMenDirec.Text = string.Empty;
                }
                else
                {
                    lblMenDirec.ForeColor = System.Drawing.Color.Red;
                    lblMenDirec.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMenDirec.ForeColor = System.Drawing.Color.Red;
                lblMenDirec.Text = "Error al leer Usuario";

            }
        }

        protected void btnEditDi_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlConDi.Text;

                if (usu.Read())
                {
                    usu.Estado = ddlEditDi.Text;
                    usu.Update();
                    lblMenResi.Text = string.Empty;
                    lblMensaje.Text = string.Empty;
                    lblMenCon.Text = string.Empty;
                    CargasUsuariosDi();
                    lblMenDirec.ForeColor = System.Drawing.Color.Green;
                    lblMenDirec.Text = "Usuario Actualizado";

                }
                else
                {
                    lblMenDirec.ForeColor = System.Drawing.Color.Red;
                    lblMenDirec.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMenDirec.ForeColor = System.Drawing.Color.Red;
                lblMenDirec.Text = "Usuario al actualizar Encargado";

            }
        }

        protected void btnConsResi_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlResiUser.Text;

                if (usu.Read())
                {

                    ddlEstadoResi.Text = Convert.ToString(usu.Estado);

                    lblMenResi.Text = string.Empty;
                }
                else
                {
                    lblMenResi.ForeColor = System.Drawing.Color.Red;
                    lblMenResi.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMenResi.ForeColor = System.Drawing.Color.Red;
                lblMenResi.Text = "Error al leer Usuario";

            }
        }

        protected void btnEditResi_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();

                usu.NombreUser = ddlResiUser.Text;

                if (usu.Read())
                {
                    usu.Estado = ddlEstadoResi.Text;
                    usu.Update();
                    CargasUsuariosRe();
                    lblMenDirec.Text = string.Empty;
                    lblMensaje.Text = string.Empty;
                    lblMenCon.Text = string.Empty;
                    lblMenResi.ForeColor = System.Drawing.Color.Green;
                    lblMenResi.Text = "Usuario Actualizado";

                }
                else
                {
                    lblMenResi.ForeColor = System.Drawing.Color.Red;
                    lblMenResi.Text = "Usuario no existe!";
                }
            }
            catch
            {
                lblMenResi.ForeColor = System.Drawing.Color.Red;
                lblMenResi.Text = "Usuario al actualizar Encargado";

            }
        }

        protected void CerrarSession_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session["Nombre"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}
