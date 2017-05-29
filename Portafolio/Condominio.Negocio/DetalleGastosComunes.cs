using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class DetalleGastosComunes
    {
        public decimal Id { get; set; }
        public string FechaGasto { get; set; }
        public string NombreGastoComun { get; set; }
        public string ValorGasto { get; set; }
        public string Observacion { get; set; }
        public decimal IdPago { get; set; }


        public bool Update()
        {
            try
            {
                Condominio.DALC.DETALLESGASCOM detallegasto = CommonBC.ModeloCondominio.DETALLESGASCOM.FirstOrDefault(bib => bib.IDPAGOGAS == this.IdPago);
                detallegasto.OBSERBACIONES = this.Observacion;
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
                
                Condominio.DALC.DETALLESGASCOM detallegasto = CommonBC.ModeloCondominio.DETALLESGASCOM.FirstOrDefault(bib => bib.ID == this.IdPago);
                this.Observacion = detallegasto.OBSERBACIONES;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
