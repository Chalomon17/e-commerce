using Microsoft.EntityFrameworkCore;
using msv.ecommerce.application.DataBase;
using msv.ecommerce.domain.Entities;
using msv.ecommerce.persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msv.ecommerce.persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ClienteEntity> Cliente { get; set; }

        public DbSet<TiendaEntity> Tienda { get; set; }

        public DbSet<ArticuloEntity> Articulo { get; set; }

        public DbSet<ArticulosTiendaEntity> ArticulosTienda { get; set; }

        public DbSet<ClienteArticulosEntity> ClienteArticulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new ClienteConfiguracion(modelBuilder.Entity<ClienteEntity>());
            new TiendaConfiguracion(modelBuilder.Entity<TiendaEntity>());
            new ArticuloConfiguracion(modelBuilder.Entity<ArticuloEntity>());
            new ClienteArticulosConfiguracion(modelBuilder.Entity<ClienteArticulosEntity>());
            new ArticulosTiendaConfiguracion(modelBuilder.Entity<ArticulosTiendaEntity>());
        }

    }
}
