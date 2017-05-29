using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class DetatalleGastosComunesCollection
    {

        private List<DetalleGastosComunes> GenerarListado(List<DALC.DETALLESGASCOM> bodegasDALC)
        {
            List<DetalleGastosComunes> gastos = new List<DetalleGastosComunes>();

            foreach (var item in bodegasDALC)
            {
                var Fecha = String.Format("{0:Y}", item.FECHAGASTOS);
                DetalleGastosComunes gasto = new DetalleGastosComunes();
                gasto.Id = item.ID;
                gasto.NombreGastoComun = item.GASTOSCOMUNES.NOMBREGAS;
                gasto.FechaGasto = Fecha.Replace("de","").Replace(Fecha.Substring(0,1),Fecha.Substring(0,1).ToUpper());
                gasto.ValorGasto = "$ "+ (Convert.ToInt64(item.VALORGASTO)).ToString("N0");
                gasto.Observacion = item.OBSERBACIONES;
                gastos.Add(gasto);
            }
            return gastos;
        }

        public int IdpagoGas { get; set; }

        public int DetalleGastosCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.IDPAGOGAS == this.IdpagoGas);

            return productos;
        }

        public List<DetalleGastosComunes> DetalleGastos()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.IDPAGOGAS == this.IdpagoGas);

            return GenerarListado(productos.ToList());
        }

        public int DetalleGastosPagarCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.IDPAGOGAS == this.IdpagoGas && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return productos;
        }

        public List<DetalleGastosComunes> DetallePagarGastos()
        {

            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.IDPAGOGAS == this.IdpagoGas && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2 );
            return GenerarListado(productos.ToList()); 
        }
    }
}
