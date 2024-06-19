using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.domain.Entities
{
    public class ClienteArticulosEntity
    {
        public Guid IdClienteArticulo { get; set; }

        public Guid IdCliente { get; set; }

        public Guid IdArticulo { get; set; }

        public DateTime Fecha { get; set; }

        public ClienteEntity Cliente { get; set; }

        public ArticuloEntity Articulo { get; set; }

    }
}
