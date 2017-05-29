using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class MultasCollection
    {

        private List<Multas> GenerarListado(List<DALC.DETALLEMULTA> bodegasDALC)
        {
            List<Multas> gastos = new List<Multas>();

            foreach (var item in bodegasDALC)
            {

                Multas gasto = new Multas();
                gasto.Id = item.ID;
                gasto.DetalleMulta = item.DETALLE;
                gasto.FechaMulta = String.Format("{0:dd/MM/yyyy}", item.FECHAMULTA);
                gasto.ValorMulta = "$ "+item.VALORMULTA.ToString("N0");
                gasto.Observacion = item.OBSERBACIONES;
                gasto.NombreUsuario = item.PAGOGASCOMUN.USUARIO.NOMBREUSER;
                gasto.Vivienda = Convert.ToString(item.PAGOGASCOMUN.USUARIO.VIVIENDA.ID);
                gasto.EstadoPago = item.PAGOGASCOMUN.ESTADOPAGO.NOMBREPAGO;
                gastos.Add(gasto);
            }
            return gastos;
        }

        public int IdpagoGas { get; set; }
        public string NombreUser { get; set; }
        public DateTime AnioIngresado { get; set; }
        public DateTime MesIngresado { get; set; }

        public int MultasCountResidente()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Count(bib => bib.IDPAGOGAS == this.IdpagoGas);

            return productos;
        }

        public List<Multas> MultasResidentes()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Where(bib => bib.IDPAGOGAS == this.IdpagoGas);

            return GenerarListado(productos.ToList());
        }

        public int MultasCountporResidente()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Count(bib => bib.FECHAMULTA.Year == this.AnioIngresado.Year && bib.FECHAMULTA.Month == this.MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == this.NombreUser);

            return productos;
        }

        public List<Multas> MultasporResidentes()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Where(bib => bib.FECHAMULTA.Year == this.AnioIngresado.Year && bib.FECHAMULTA.Month == this.MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == this.NombreUser);

            return GenerarListado(productos.ToList());
        }

        public int MultasCountPagarResidente()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Count(bib => bib.IDPAGOGAS == this.IdpagoGas && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return productos;
        }

        public List<Multas> MultasPagarResidentes()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Where(bib => bib.IDPAGOGAS == this.IdpagoGas && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return GenerarListado(productos.ToList());
        }

        public int MultasCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Count(bib => bib.FECHAMULTA.Year == this.AnioIngresado.Year && bib.FECHAMULTA.Month == this.MesIngresado.Month);

            return productos;
        }

        public List<Multas> Multas()
        {
            var productos = CommonBC.ModeloCondominio.DETALLEMULTA.Where(bib => bib.FECHAMULTA.Year == this.AnioIngresado.Year && bib.FECHAMULTA.Month == this.MesIngresado.Month);

            return GenerarListado(productos.ToList());
        }
    }
}
