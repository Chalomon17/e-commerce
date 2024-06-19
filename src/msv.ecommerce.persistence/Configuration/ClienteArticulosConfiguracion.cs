using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msv.ecommerce.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.persistence.Configuration
{
    public class ClienteArticulosConfiguracion
    {
        public ClienteArticulosConfiguracion(EntityTypeBuilder<ClienteArticulosEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdClienteArticulo);
            entityBuilder.Property(x => x.IdArticulo).IsRequired();
            entityBuilder.Property(x => x.IdCliente).IsRequired();
            entityBuilder.Property(x => x.Fecha).IsRequired();

            entityBuilder.HasOne(x => x.Cliente)
                .WithMany(x => x.ClienteArticulos)
                .HasForeignKey(x => x.IdCliente);

            entityBuilder.HasOne(x => x.Articulo)
                .WithMany(x => x.ClienteArticulos)
                .HasForeignKey(x=> x.IdArticulo);
        }
    }
}
