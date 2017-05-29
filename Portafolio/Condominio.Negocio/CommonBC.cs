using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Condominio.DALC;

namespace Condominio.Negocio
{
    public class CommonBC
    {

        private static CondominioEntities _modeloCondominio;

        public static CondominioEntities ModeloCondominio
        {
            get
            {
                if (_modeloCondominio == null)
                {
                    _modeloCondominio = new CondominioEntities();
                }

                return _modeloCondominio;
            }

        }

    }
}
