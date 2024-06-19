using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msv.ecommerce.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.persistence.Configuration
{
    public class TiendaConfiguracion
    {
        public TiendaConfiguracion(EntityTypeBuilder<TiendaEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdTienda);
            entityBuilder.Property(x => x.Sucursal).IsRequired();
            entityBuilder.Property(x => x.Direccion).IsRequired();

            entityBuilder.HasMany(x => x.ArticulosTiendas)
                .WithOne(x => x.Tienda)
                .HasForeignKey(x => x.IdTienda);
        }
    }
}
