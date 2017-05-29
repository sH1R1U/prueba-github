using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class GastosComunesCollection
    {
        private List<GastosComunes> GenerarListado(List<DALC.DETALLESGASCOM> bodegasDALC)
        {
            List<GastosComunes> gastos = new List<GastosComunes>();

            foreach (var item in bodegasDALC)
            {

                GastosComunes gasto = new GastosComunes();
                gasto.Id = item.PAGOGASCOMUN.ID;
                gasto.vivienda = item.PAGOGASCOMUN.USUARIO.IDVIVIENDA;
                gasto.usuario = item.PAGOGASCOMUN.USUARIO.NOMBRECOMPLETO;
                gasto.FechaGasto = String.Format("{0:Y}",item.FECHAGASTOS);
                gasto.ValorTotal = "$ "+(Convert.ToInt64(item.PAGOGASCOMUN.VALORTOTAL)).ToString("N0");
                gasto.EstadoPago = item.PAGOGASCOMUN.ESTADOPAGO.NOMBREPAGO;
                if (item.PAGOGASCOMUN.FECHAPAGO != null)
                {
                    gasto.FechaPago = String.Format("{0:dd/MM/yyyy}",item.PAGOGASCOMUN.FECHAPAGO);
                }
                else
                {
                    gasto.FechaPago = "Pendiente";
                }
                



                gastos.Add(gasto);
            }
            return gastos;
        }


        public DateTime AnioIngresado { get; set; }
        public DateTime MesIngresado { get; set; }
        public string NombreUser { get; set; }
        public int IdPagoGasto { get; set; }
        
        

        public int PagosGastosCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.VALORTOTAL != 0);
            return productos;
        }

        public List<GastosComunes> PagosGastos()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.VALORTOTAL != 0);

            return GenerarListado(productos.ToList());
        }

        public List<GastosComunes> PagosGastosPendientes()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.IDESTADOPAGO == 2 && bib.PAGOGASCOMUN.VALORTOTAL != 0);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosCountPendientes()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.IDESTADOPAGO == 2 && bib.PAGOGASCOMUN.VALORTOTAL != 0);
            return productos;
        }

        public List<GastosComunes> PagosGastosPendientesResidente()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == NombreUser && bib.PAGOGASCOMUN.VALORTOTAL != 0);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosCountPendientesResidentes()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == NombreUser && bib.PAGOGASCOMUN.VALORTOTAL != 0);
            return productos;
        }

        public List<GastosComunes> PagosGastosPendien()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == NombreUser && bib.PAGOGASCOMUN.VALORTOTAL != 0 && bib.FECHAGASTOS != null);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosPendienCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == NombreUser && bib.PAGOGASCOMUN.VALORTOTAL != 0 && bib.FECHAGASTOS != null);

            return productos;

        }

        public List<GastosComunes> PagosGastosParaPagar()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.PAGOGASCOMUN.ID == IdPagoGasto && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosParaPagarCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.PAGOGASCOMUN.ID == IdPagoGasto && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return productos;

        }

        public List<GastosComunes> PagosGastosPendientesPagar()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Where(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == NombreUser && bib.PAGOGASCOMUN.VALORTOTAL != 0 && bib.FECHAGASTOS != null && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosPendientesPagarCount()
        {
            var productos = CommonBC.ModeloCondominio.DETALLESGASCOM.Count(bib => bib.FECHAGASTOS.Year == AnioIngresado.Year && bib.FECHAGASTOS.Month == MesIngresado.Month && bib.PAGOGASCOMUN.USUARIO.NOMBREUSER == NombreUser && bib.PAGOGASCOMUN.VALORTOTAL != 0 && bib.FECHAGASTOS != null && bib.PAGOGASCOMUN.ESTADOPAGO.ID == 2);

            return productos;

        }


    }
}