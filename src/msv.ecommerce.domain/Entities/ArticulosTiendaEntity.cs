using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.domain.Entities
{
    public class ArticulosTiendaEntity
    {
        public Guid IdArticulosTienda { get; set; }

        public Guid IdArticulo { get; set; }

        public Guid IdTienda { get; set; }

        public DateTime Fecha { get; set; }

        public ArticuloEntity Articulo { get; set; }

        public TiendaEntity Tienda { get; set; }

    }
}
