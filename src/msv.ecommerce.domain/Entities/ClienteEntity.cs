using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.domain.Entities
{
    public class ClienteEntity
    {
        public Guid IdCliente { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string Direccion { get; set; }

        public ICollection<ClienteArticulosEntity> ClienteArticulos { get; set; }

    }
}
