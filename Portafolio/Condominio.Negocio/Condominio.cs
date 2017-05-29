using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Condominio.DALC;

namespace Condominio.Negocio
{
    public class Condominioo
    {
        public decimal Id { get; set; }
        public string Comuna { get; set; }
        public string Direccion { get; set; }
        public string Dueno { get; set; }

        public bool Read()
        {
            try
            {
                DALC.CONDOMINIO Producto = CommonBC.ModeloCondominio.CONDOMINIO.FirstOrDefault(bib => bib.ID == this.Id);
                this.Id = Producto.ID;
                this.Comuna = Producto.COMUNA;
                this.Direccion = Producto.DIRECCION;
                this.Dueno = Producto.NOMBREDUENO;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }


}