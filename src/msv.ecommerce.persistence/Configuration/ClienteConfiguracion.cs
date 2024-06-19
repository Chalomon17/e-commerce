using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msv.ecommerce.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.persistence.Configuration
{
    public class ClienteConfiguracion
    {
        public ClienteConfiguracion(EntityTypeBuilder<ClienteEntity> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.IdCliente);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.ApellidoPaterno).IsRequired();
            entityBuilder.Property(x => x.ApellidoMaterno).IsRequired();
            entityBuilder.Property(x => x.Direccion).IsRequired();

            entityBuilder.HasMany(x => x.ClienteArticulos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.IdCliente);

        }
    }
}
