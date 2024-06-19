using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.domain.Entities
{
    public class ArticuloEntity
    {
        public Guid IdArticulo { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public string Precio { get; set; }

        public byte[] Imagen { get; set; }

        public int Stock { get; set; }

        public ICollection<ArticulosTiendaEntity> ArticulosTiendas { get; set; }

        public ICollection<ClienteArticulosEntity> ClienteArticulos { get; set; }
    }
}
