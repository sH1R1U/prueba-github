using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class UsuarioCollection
    {
        private List<Usuario> GenerarListado(List<DALC.USUARIO> bodegasDALC)
        {
            List<Usuario> usuarios = new List<Usuario>();

            foreach (var item in bodegasDALC)
            {
                Usuario usuario = new Usuario
                {
                    Id = item.ID,
                    NombreCompleto = item.NOMBRECOMPLETO,
                    Rut = item.RUT,
                    Telefono = item.TELEFONO,
                    Correo = item.CORREO,
                    NombreUser = item.NOMBREUSER,
                    Contrasena = item.CONTRASENA,
                    Login = item.TIPOUSUARIO.NOMBRETIPO,
                    NVivienda = item.IDVIVIENDA,
                    Estado = item.ESTADOUSER.ESTADO
                };
                usuarios.Add(usuario);
            }
            return usuarios;

        }

        //Rescatar el ultimo ID ingresado
        public List<Usuario> BodegasMasProducto()
        {
            var maximo = CommonBC.ModeloCondominio.USUARIO.Max(bib => bib.ID);
            var Resultado = CommonBC.ModeloCondominio.USUARIO.Where(bib => bib.ID == maximo);

            return (GenerarListado(Resultado.ToList()));
        }

        public List<Usuario> UsuariosResidentes()
        {
            var productos = CommonBC.ModeloCondominio.USUARIO.Where(bib => bib.IDTIPOUSER == 4);

            return GenerarListado(productos.ToList());
        }

        public List<Usuario> UsuariosDirectiva()
        {
            var productos = CommonBC.ModeloCondominio.USUARIO.Where(bib => bib.IDTIPOUSER == 3);

            return GenerarListado(productos.ToList());
        }

        public List<Usuario> UsuariosAdministrador()
        {
            var productos = CommonBC.ModeloCondominio.USUARIO.Where(bib => bib.IDTIPOUSER == 1);

            return GenerarListado(productos.ToList());
        }

        public List<Usuario> UsuariosConserje()
        {
            var productos = CommonBC.ModeloCondominio.USUARIO.Where(bib => bib.IDTIPOUSER == 2);

            return GenerarListado(productos.ToList());
        }
    }
}
