using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condominio.Negocio
{
    public class ConsultaCollection
    {
        private List<Consultas> GenerarListado(List<DALC.CONTACTO> bodegasDALC)
        {
            List<Consultas> consultas = new List<Consultas>();

            foreach (var item in bodegasDALC)
            {
                Consultas consulta = new Consultas
                {
                    Id = item.ID,
                    Detalle = item.DETALLE,
                    Solucion = item.SOLUCION,
                    NombreAdmin = item.USUARIO.NOMBRECOMPLETO,
                    IdUser = item.USUARIO.NOMBREUSER
                };
                consultas.Add(consulta);
            }
            return consultas;

        }

        public decimal IdUser { get; set; }

        public int ConsultasResidentesCount()
        {
            var productos = CommonBC.ModeloCondominio.CONTACTO.Count(bib => bib.IDUSER == this.IdUser);

            return productos;
        }

        public List<Consultas> ConsultasResidentes()
        {
            var productos = CommonBC.ModeloCondominio.CONTACTO.Where(bib => bib.IDUSER == this.IdUser);

            return GenerarListado(productos.ToList());
        }
    }
}