﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class PagoGastoComunes
    {
        public decimal Id { get; set; }
        public string FechaGasto { get; set; }
        public string FechaPago { get; set; }
        public string ValorGasto { get; set; }
        public string MedioPago { get; set; }
        public string EstadoPago { get; set; }
        public string NomUser {get; set;}
        public decimal vivienda { get; set; }
        public string usuario { get; set; }
        public string ValorTotal { get; set; }
        public string Observacion { get; set; }
    }
}
