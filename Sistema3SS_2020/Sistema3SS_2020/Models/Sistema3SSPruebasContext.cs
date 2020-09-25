using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Sistema3SSPruebasContext : DbContext
    {
        public Sistema3SSPruebasContext()
        {
        }

        public Sistema3SSPruebasContext(DbContextOptions<Sistema3SSPruebasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Concepcion> Concepcions { get; set; }
        public virtual DbSet<ConceptosGasto> ConceptosGastos { get; set; }
        public virtual DbSet<DetalleGranja> DetalleGranjas { get; set; }
        public virtual DbSet<DetallePresupuesto> DetallePresupuestos { get; set; }
        public virtual DbSet<DetalleProyecto> DetalleProyectos { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<Granja> Granjas { get; set; }
        public virtual DbSet<Insumo> Insumos { get; set; }
        public virtual DbSet<Presupuesto> Presupuestos { get; set; }
        public virtual DbSet<Proyeccione> Proyecciones { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<SemanasTemporadum> SemanasTemporada { get; set; }
        public virtual DbSet<Temporada> Temporadas { get; set; }
        public virtual DbSet<TiposInsumo> TiposInsumos { get; set; }
        public virtual DbSet<TiposPresupuesto> TiposPresupuestos { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concepcion>(entity =>
            {
                entity.ToTable("CONCEPCION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ConceptosGasto>(entity =>
            {
                entity.ToTable("CONCEPTOS_GASTOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Contenido)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DetalleGranja>(entity =>
            {
                entity.ToTable("DETALLE_GRANJA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdDetalleProyecto).HasColumnName("idDetalle_proyecto");

                entity.Property(e => e.IdGranja).HasColumnName("idGranja");

                entity.Property(e => e.NumeroEstanque).HasColumnName("numeroEstanque");

                entity.HasOne(d => d.IdGranjaNavigation)
                    .WithMany(p => p.DetalleGranjas)
                    .HasForeignKey(d => d.IdGranja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETALLE_GRANJA_GRANJAS");
            });

            modelBuilder.Entity<DetallePresupuesto>(entity =>
            {
                entity.ToTable("DETALLE_PRESUPUESTOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Estanques)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.IdConcepcion).HasColumnName("idConcepcion");

                entity.Property(e => e.IdGasto).HasColumnName("idGasto");

                entity.Property(e => e.IdGranja).HasColumnName("idGranja");

                entity.Property(e => e.IdPresupuesto).HasColumnName("idPresupuesto");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");
            });

            modelBuilder.Entity<DetalleProyecto>(entity =>
            {
                entity.ToTable("DETALLE_PROYECTOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdTemporada).HasColumnName("idTemporada");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.ToTable("GASTOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GASTOS_CONCEPTOS_GASTOS");
            });

            modelBuilder.Entity<Granja>(entity =>
            {
                entity.ToTable("GRANJAS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ApellidoMaternoResponsable)
                    .HasMaxLength(50)
                    .HasColumnName("apellido_materno_responsable")
                    .IsFixedLength(true);

                entity.Property(e => e.ApellidoPaternoResponsable)
                    .HasMaxLength(50)
                    .HasColumnName("apellido_paterno_responsable")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);

                entity.Property(e => e.NombreResponsable)
                    .HasMaxLength(50)
                    .HasColumnName("nombre_responsable")
                    .IsFixedLength(true);

                entity.Property(e => e.NumeroEstanques).HasColumnName("numero_estanques");

                entity.Property(e => e.PerimetroHectareas).HasColumnName("perimetro_hectareas");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .HasColumnName("ubicacion")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Insumo>(entity =>
            {
                entity.ToTable("INSUMOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);

                entity.Property(e => e.UnidadMedida)
                    .HasMaxLength(10)
                    .HasColumnName("unidad_medida")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Insumos)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_INSUMOS_TIPOS_INSUMOS");
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.ToTable("PRESUPUESTOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.TotalPresupuesto).HasColumnName("total_presupuesto");
            });

            modelBuilder.Entity<Proyeccione>(entity =>
            {
                entity.ToTable("PROYECCIONES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FinalSemana)
                    .HasColumnType("datetime")
                    .HasColumnName("final_semana")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.GastoEstimado).HasColumnName("gasto_estimado");

                entity.Property(e => e.IdPresupuesto).HasColumnName("idPresupuesto");

                entity.Property(e => e.IdSemana).HasColumnName("idSemana");

                entity.Property(e => e.IncioSemana)
                    .HasColumnType("datetime")
                    .HasColumnName("incio_semana")
                    .HasAnnotation("Relational:ColumnType", "datetime");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.ToTable("PROYECTOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_final")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.FechaInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_inicial")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROYECTOS_USUARIOS");
            });

            modelBuilder.Entity<SemanasTemporadum>(entity =>
            {
                entity.ToTable("SEMANAS_TEMPORADA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_final")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.FechaInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_inicial")
                    .HasAnnotation("Relational:ColumnType", "datetime");
            });

            modelBuilder.Entity<Temporada>(entity =>
            {
                entity.ToTable("TEMPORADAS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_final")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.FechaInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_inicial")
                    .HasAnnotation("Relational:ColumnType", "datetime");
            });

            modelBuilder.Entity<TiposInsumo>(entity =>
            {
                entity.ToTable("TIPOS_INSUMOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Contexto)
                    .HasMaxLength(30)
                    .HasColumnName("contexto")
                    .IsFixedLength(true);

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .HasColumnName("marca")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TiposPresupuesto>(entity =>
            {
                entity.ToTable("TIPOS_PRESUPUESTOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.ToTable("TIPOS_USUARIOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NivelSeguridad).HasColumnName("nivel_seguridad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .HasColumnName("apellido_materno")
                    .IsFixedLength(true);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .HasColumnName("apellido_paterno")
                    .IsFixedLength(true);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(100)
                    .HasColumnName("contrasena")
                    .IsFixedLength(true);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .HasColumnName("correo_electronico")
                    .IsFixedLength(true);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNecimineto)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_necimineto")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);

                entity.Property(e => e.NumeroCelular)
                    .HasMaxLength(50)
                    .HasColumnName("numero_celular")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_TIPOS_USUARIOS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
