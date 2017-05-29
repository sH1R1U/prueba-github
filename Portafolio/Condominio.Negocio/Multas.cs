using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class Multas
    {
        public decimal Id { get; set; }
        public string FechaMulta { get; set; }
        public string DetalleMulta { get; set; }
        public string ValorMulta { get; set; }
        public string Observacion { get; set; }
        public decimal IdPago { get; set; }
        public string EstadoPago { get; set; }
        public string NombreUsuario { get; set; }
        public string Vivienda { get; set; }

        public bool Update()
        {
            try
            {
                Condominio.DALC.DETALLEMULTA detallegasto = CommonBC.ModeloCondominio.DETALLEMULTA.FirstOrDefault(bib => bib.IDPAGOGAS == this.IdPago);
                detallegasto.OBSERBACIONES = this.Observacion;
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
