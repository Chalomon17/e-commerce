using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msv.ecommerce.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.persistence.Configuration
{
    public class ArticulosTiendaConfiguracion
    {
        public ArticulosTiendaConfiguracion(EntityTypeBuilder<ArticulosTiendaEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdArticulosTienda);
            entityBuilder.Property(x => x.IdArticulo).IsRequired();
            entityBuilder.Property(x => x.IdTienda).IsRequired();
            entityBuilder.Property(x => x.Fecha).IsRequired();

            entityBuilder.HasOne(x => x.Articulo)
                .WithMany(x => x.ArticulosTiendas)
                .HasForeignKey(x => x.IdArticulo);

            entityBuilder.HasOne(x => x.Tienda)
                .WithMany(x => x.ArticulosTiendas)
                .HasForeignKey(x => x.IdTienda);
        }
    }
}
