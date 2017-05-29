using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class PagoGastoComunCollection
    {

        private List<PagoGastoComunes> GenerarListado(List<DALC.PAGOGASCOMUN> bodegasDALC)
        {
            List<PagoGastoComunes> gastos = new List<PagoGastoComunes>();

            foreach (var item in bodegasDALC)
            {
                
                var Fecha = String.Format("{0:Y}", item.FECHAGASTO);
                PagoGastoComunes gasto = new PagoGastoComunes();
                gasto.Id = item.ID;
                gasto.vivienda = item.USUARIO.IDVIVIENDA;
                gasto.usuario = item.USUARIO.NOMBRECOMPLETO;
                gasto.FechaGasto = Fecha.Replace("de", "").Replace(Fecha.Substring(0, 1), Fecha.Substring(0, 1).ToUpper());

                gasto.ValorTotal = "$ "+((Convert.ToInt64(item.VALORTOTAL))).ToString("N0");
                gasto.EstadoPago = item.ESTADOPAGO.NOMBREPAGO;
                if (item.FECHAPAGO != null)
                {
                    gasto.FechaPago = String.Format("{0:dd/MM/yyyy}", item.FECHAPAGO);
                }
                else
                {
                    gasto.FechaPago = "Pendiente";
                }

                gastos.Add(gasto);
            }
            return gastos;
        }

        public string FormatoFecha(string Fecha)
        {
             var Letra = Fecha.Substring(0, 1);
             var Mayuscula = Letra.ToUpper();
             var Mes = Fecha.Replace(Letra,"");

             return (Mayuscula + Mes).Replace("de", "");
            
        }

    

        public DateTime AnioIngresado { get; set; }
        public DateTime MesIngresado { get; set; }
        public string NombreUser { get; set; }
        public int IdPagoGasto { get; set; }



        public int PagosGastosCount()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Count(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.VALORTOTAL != 0);
            return productos;
        }

        public List<PagoGastoComunes> PagosGastos()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Where(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.VALORTOTAL != 0);

            return GenerarListado(productos.ToList());
        }

        public List<PagoGastoComunes> PagosGastosPendientes()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Where(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.IDESTADOPAGO == 2 && bib.VALORTOTAL != 0);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosCountPendientes()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Count(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.IDESTADOPAGO == 2 && bib.VALORTOTAL != 0);
            return productos;
        }

        public List<PagoGastoComunes> PagosGastosPendientesResidente()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Where(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.USUARIO.NOMBREUSER == NombreUser && bib.VALORTOTAL != 0);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosCountPendientesResidentes()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Count(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.USUARIO.NOMBREUSER == NombreUser && bib.VALORTOTAL != 0);
            return productos;
        }

        public List<PagoGastoComunes> PagosGastosPendien()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Where(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.USUARIO.NOMBREUSER == NombreUser && bib.VALORTOTAL != 0 && bib.FECHAGASTO != null);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosPendienCount()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Count(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.USUARIO.NOMBREUSER == NombreUser && bib.VALORTOTAL != 0 && bib.FECHAGASTO != null);

            return productos;

        }

        public List<PagoGastoComunes> PagosGastosParaPagar()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Where(bib => bib.ID == IdPagoGasto && bib.ESTADOPAGO.ID == 2);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosParaPagarCount()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Count(bib => bib.ID == IdPagoGasto && bib.ESTADOPAGO.ID == 2);

            return productos;

        }

        public List<PagoGastoComunes> PagosGastosPendientesPagar()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Where(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.USUARIO.NOMBREUSER == NombreUser && bib.VALORTOTAL != 0 && bib.FECHAGASTO != null && bib.ESTADOPAGO.ID == 2);

            return GenerarListado(productos.ToList());
        }

        public int PagosGastosPendientesPagarCount()
        {
            var productos = CommonBC.ModeloCondominio.PAGOGASCOMUN.Count(bib => bib.FECHAGASTO.Year == AnioIngresado.Year && bib.FECHAGASTO.Month == MesIngresado.Month && bib.USUARIO.NOMBREUSER == NombreUser && bib.VALORTOTAL != 0 && bib.FECHAGASTO != null && bib.ESTADOPAGO.ID == 2);

            return productos;

        }


    }
}