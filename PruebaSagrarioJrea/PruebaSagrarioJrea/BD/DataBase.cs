
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace PruebaSagrarioJrea.BD
{
    public partial class  Database : DbContext
    {
        public Database()
        {
        }

        public Database(DbContextOptions<Database> options)
            : base(options)
        {
        }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<FacturaCabecera> FacturaCabeceras { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                var Server = "172.16.1.148,40103";
                var Database = "dbSagrario";
                var id = "sa";
                var password = "Viamatica2000";
                var TrustServerCertificate = "true";
                var PersistSecurityInfo = "true";
                var cadenaFinal = $"Server={Server};Database={Database};user id={id};password={password};TrustServerCertificate={TrustServerCertificate};Persist Security Info={PersistSecurityInfo}";
                optionsBuilder.UseSqlServer(cadenaFinal);
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.idCliente)
                    .HasName("PK__usuario__079F540B1582E020");

                entity.ToTable("clientes");

                entity.Property(e => e.idCliente).HasColumnName("idCliente");

                entity.Property(e => e.identificacion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.nombres)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.apellidos)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.celular)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.idProducto)
                    .HasName("PK__token__079F540B1582E020");

                entity.ToTable("productos");

                entity.Property(e => e.idProducto)
                    .HasColumnName("idProducto");

                entity.Property(e => e.nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.precio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.idFactura)
                    .HasName("PK__token__079F540B1582E020");

                entity.ToTable("facturas");

                entity.Property(e => e.idFactura)
                    .HasColumnName("idFactura");

                entity.Property(e => e.idFacturaCabecera)
                    .IsUnicode(false);

                entity.Property(e => e.subtotal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.iva)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.total)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne<FacturaCabecera>()
                    .WithMany()
                    .HasForeignKey(e => e.idFacturaCabecera)
                    .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<FacturaCabecera>(entity =>
            {
                entity.HasKey(e => e.idFacturaCabecera)
                    .HasName("PK__token__079F540B1582E020");

                entity.ToTable("facturaCabecera");

                entity.Property(e => e.idFacturaCabecera)
                    .HasColumnName("idFacturaCabecera");

                entity.Property(e => e.idCliente)
                    .IsUnicode(false);

                entity.Property(e => e.fechaEmision)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne<Cliente>()
                    .WithMany()
                    .HasForeignKey(e => e.idCliente)
                    .OnDelete(DeleteBehavior.Restrict);


            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.HasKey(e => e.idFacturaDetalle)
                    .HasName("PK__token__079F540B1582E020");

                entity.ToTable("facturaDetalle");

                entity.Property(e => e.idFacturaDetalle)
                    .HasColumnName("idFacturaDetalle");

                entity.Property(e => e.idFacturaCabecera)
                    .IsUnicode(false);

                entity.Property(e => e.idProducto)
                    .IsUnicode(false);

                entity.Property(e => e.cantidad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.total)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne<FacturaCabecera>()
                    .WithMany()
                    .HasForeignKey(e => e.idFacturaCabecera)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Producto>()
                    .WithMany()
                    .HasForeignKey(e => e.idProducto)
                    .OnDelete(DeleteBehavior.Restrict);

            });

        }
    }
}
