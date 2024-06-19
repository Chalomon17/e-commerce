using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.domain.Entities
{
    public class TiendaEntity
    {
        public Guid IdTienda { get; set; }

        public string Sucursal { get; set; }

        public string Direccion { get; set; }

        public ICollection<ArticulosTiendaEntity> ArticulosTiendas { get; set; }
    }
}
