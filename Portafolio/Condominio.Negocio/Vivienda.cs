using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Condominio.Negocio
{
    public class Vivienda
    {
        public decimal Id { get; set; }
        public string Tipo_Vivienda { get; set; }
        public decimal Numero_Vivienda { get; set; }
        public decimal Id_Condiminio { get; set; }
        public decimal Numero_Condiminio { get; set; }

        public bool Read()
        {
            try
            {
                DALC.VIVIENDA Producto = CommonBC.ModeloCondominio.VIVIENDA.FirstOrDefault(bib => bib.ID == this.Id);
                this.Id = Producto.ID;
                this.Tipo_Vivienda = Producto.TIPOVIVIENDA;
                this.Id_Condiminio = (decimal)Producto.IDCONDOMINIO;
                this.Numero_Condiminio = Producto.IDCONDOMINIO;

                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}
