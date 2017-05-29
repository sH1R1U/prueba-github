using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;


namespace Condominio.Negocio
{
    public class Usuario
    {
        public decimal Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Rut { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string NombreUser { get; set; }
        public string Contrasena { get; set; }
        public string Login { get; set; }
        public decimal NVivienda { get; set; }
        public string Estado { get; set; }

        public Usuario()
        {
            this.Init();
        }

        private void Init()
        {
            Id = 0;
            NombreCompleto = string.Empty;
            Rut = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            NombreUser = string.Empty;
            Contrasena = string.Empty;
            Login = string.Empty;
            NVivienda = 0;
            Estado = string.Empty;

        }



        public bool Create()
        {
            try
            {
                DALC.USUARIO user = new DALC.USUARIO();
                user.ID = this.Id;
                user.NOMBRECOMPLETO = this.NombreCompleto;
                user.RUT = this.Rut;
                user.TELEFONO = this.Telefono;
                user.CORREO = this.Correo;
                user.NOMBREUSER = this.NombreUser;
                user.CONTRASENA = this.Contrasena;
                user.IDTIPOUSER = int.Parse(this.Login);
                user.IDVIVIENDA = this.NVivienda;
                user.IDESTADO = int.Parse(this.Estado);

                CommonBC.ModeloCondominio.AddToUSUARIO(user);
                CommonBC.ModeloCondominio.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Condominio.DALC.USUARIO user = CommonBC.ModeloCondominio.USUARIO.FirstOrDefault(u => u.NOMBREUSER == this.NombreUser);
                this.Id = user.ID;
                this.NombreCompleto = user.NOMBRECOMPLETO;
                this.Rut = user.RUT;
                this.Telefono = user.TELEFONO;
                this.Correo = user.CORREO;
                this.NombreUser = user.NOMBREUSER;
                this.Contrasena = user.CONTRASENA;
                this.Login = Convert.ToString(user.IDTIPOUSER);
                this.NVivienda = user.IDVIVIENDA;
                this.Estado = Convert.ToString(user.IDESTADO);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ReadId()
        {
            try
            {
                Condominio.DALC.USUARIO user = CommonBC.ModeloCondominio.USUARIO.FirstOrDefault(u => u.ID == this.Id);
                this.Id = user.ID;
                this.NombreCompleto = user.NOMBRECOMPLETO;
                this.Rut = user.RUT;
                this.Telefono = user.TELEFONO;
                this.Correo = user.CORREO;
                this.NombreUser = user.NOMBREUSER;
                this.Contrasena = user.CONTRASENA;
                this.Login = Convert.ToString(user.IDTIPOUSER);
                this.NVivienda = user.IDVIVIENDA;
                this.Estado = Convert.ToString(user.IDESTADO);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Update()
        {
            try
            {
                Condominio.DALC.USUARIO usuario = CommonBC.ModeloCondominio.USUARIO.FirstOrDefault(bib => bib.ID == this.Id);
                usuario.IDESTADO = int.Parse(this.Estado);

                CommonBC.ModeloCondominio.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Perfil()
        {
            try
            {
                DALC.USUARIO user = CommonBC.ModeloCondominio.USUARIO.Where(u => u.ID == this.Id).FirstOrDefault();

                this.Id = user.ID;
                this.NombreCompleto = user.NOMBRECOMPLETO;
                this.Rut = user.RUT;
                this.Telefono = user.TELEFONO;
                this.Correo = user.CORREO;
                this.NombreUser = user.NOMBREUSER;
                this.Contrasena = user.CONTRASENA;
                this.Login = Convert.ToString(user.TIPOUSUARIO.NOMBRETIPO);
                this.NVivienda = user.IDVIVIENDA;
                this.Estado = Convert.ToString(user.IDESTADO);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool ValidarUsuario()
        {
            DALC.USUARIO user = CommonBC.ModeloCondominio.USUARIO.Where(u => u.NOMBREUSER == this.NombreUser && u.CONTRASENA == this.Contrasena).FirstOrDefault();

            if (user != null)
                return true;
            else
                return false;
        }

        public string Serializar()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            StringWriter writer = new StringWriter();
            serializador.Serialize(writer, this);
            writer.Close();
            return writer.ToString();
        }


        public Usuario(string xml)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            StringReader reader = new StringReader(xml);
            Usuario user = (Usuario)serializador.Deserialize(reader);
            this.Id = user.Id;
            this.NombreCompleto = user.NombreCompleto;
            this.Rut = user.Rut;
            this.Telefono = user.Telefono;
            this.Correo = user.Correo;
            this.NombreUser = user.NombreUser;
            this.Contrasena = user.Contrasena;
            this.Login = user.Login;
            this.NVivienda = user.NVivienda;
            this.Estado = user.Estado;
        }
    }
}

