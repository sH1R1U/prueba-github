using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class Consultas
    {
        public decimal Id { get; set; }
        public string Detalle { get; set; }
        public string Solucion { get; set; }
        public string NombreAdmin { get; set; }
        public string IdUser { get; set; }

        public Consultas()
        {
            this.Init();
        }

        private void Init()
        {
            Id = 0;
            Detalle = string.Empty;
            Solucion = string.Empty;
            NombreAdmin = string.Empty;
            IdUser = string.Empty;
        }

        public decimal id()
        {
            decimal Idnew = CommonBC.ModeloCondominio.CONTACTO.Max(bib => bib.ID);
            decimal sumaIdnew = Idnew + 1;
            return sumaIdnew;
        }

        public bool Create()
        {
            try
            {
                DALC.CONTACTO consulta = new DALC.CONTACTO();
                consulta.ID = id();
                consulta.DETALLE = this.Detalle;
                consulta.SOLUCION = this.Solucion;
                consulta.NOMBREADMIN = this.NombreAdmin;
                consulta.IDUSER = Convert.ToDecimal(this.IdUser);
                CommonBC.ModeloCondominio.AddToCONTACTO(consulta);
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
                Condominio.DALC.CONTACTO consulta = CommonBC.ModeloCondominio.CONTACTO.FirstOrDefault(u => u.ID == this.Id);
                this.Id = Convert.ToDecimal(consulta.ID);
                this.Detalle = consulta.DETALLE;
                this.Solucion = consulta.SOLUCION;
                this.NombreAdmin = consulta.NOMBREADMIN;
                this.IdUser = Convert.ToString(consulta.IDUSER);
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
                Condominio.DALC.CONTACTO consulta = CommonBC.ModeloCondominio.CONTACTO.FirstOrDefault(bib => bib.ID == this.Id);
                consulta.SOLUCION = this.Solucion;
                consulta.NOMBREADMIN = this.NombreAdmin;
                CommonBC.ModeloCondominio.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        

    }
}