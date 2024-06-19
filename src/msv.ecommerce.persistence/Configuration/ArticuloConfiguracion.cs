using Microsoft.EntityFrameworkCore.Metadata.Builders;
using msv.ecommerce.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.persistence.Configuration
{
    public class ArticuloConfiguracion
    {
        public ArticuloConfiguracion(EntityTypeBuilder<ArticuloEntity> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.IdArticulo);
            entityBuilder.Property(x => x.Codigo).IsRequired();
            entityBuilder.Property(x => x.Descripcion).IsRequired();
            entityBuilder.Property(x => x.Precio).IsRequired();
            entityBuilder.Property(x => x.Imagen).IsRequired();
            entityBuilder.Property(x => x.Stock).IsRequired();

            entityBuilder.HasMany(x => x.ClienteArticulos)
                .WithOne(x => x.Articulo)
                .HasForeignKey(x => x.IdArticulo);

            entityBuilder.HasMany(x => x.ArticulosTiendas)
                .WithOne(x => x.Articulo)
                .HasForeignKey(x => x.IdArticulo);

        }
    }
}
