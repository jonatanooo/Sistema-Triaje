using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Fase_1_C_.Models;

public partial class TriajeClinicoContext : DbContext
{
    public TriajeClinicoContext()
    {
    }

    public TriajeClinicoContext(DbContextOptions<TriajeClinicoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NivelesTriaje> NivelesTriajes { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<RegistrosTriaje> RegistrosTriajes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FTN7C18\\SQL2022V2; Database=TriajeClinico; User Id=sa; Password=12345; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NivelesTriaje>(entity =>
        {
            entity.HasKey(e => e.IdNivel).HasName("PK__Niveles___E66BB124B571EED6");

            entity.ToTable("Niveles_Triaje");

            entity.HasIndex(e => e.Color, "UQ__Niveles___E11D3845C8BF6BE7").IsUnique();

            entity.Property(e => e.IdNivel).HasColumnName("ID_Nivel");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TiempoMaxEspera).HasColumnName("Tiempo_Max_Espera");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.IdPaciente).HasName("PK__Paciente__5F365061D8B510F7");

            entity.HasIndex(e => e.DuiPaciente, "UQ__Paciente__599717A1B3121A82").IsUnique();

            entity.Property(e => e.IdPaciente).HasColumnName("ID_Paciente");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DuiPaciente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DUI_Paciente");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegistrosTriaje>(entity =>
        {
            entity.HasKey(e => e.IdRegistro).HasName("PK__Registro__8EC639F274819BAE");

            entity.ToTable("Registros_Triaje");

            entity.Property(e => e.IdRegistro).HasColumnName("ID_Registro");
            entity.Property(e => e.EstadoAtencion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Estado_Atencion");
            entity.Property(e => e.EstadoMental)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Estado_Mental");
            entity.Property(e => e.FechaHoraAtencion)
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Atencion");
            entity.Property(e => e.FechaHoraIngreso)
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Ingreso");
            entity.Property(e => e.IdNivelAsignado).HasColumnName("ID_NivelAsignado");
            entity.Property(e => e.IdPaciente).HasColumnName("ID_Paciente");
            entity.Property(e => e.IdUsuarioEnfermera).HasColumnName("ID_Usuario_Enfermera");
            entity.Property(e => e.IdUsuarioMedico).HasColumnName("ID_Usuario_Medico");
            entity.Property(e => e.MecanismoLesion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mecanismo_Lesion");
            entity.Property(e => e.MotivoConsulta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Motivo_Consulta");
            entity.Property(e => e.NivelDolor).HasColumnName("Nivel_Dolor");
            entity.Property(e => e.SaturacionO2).HasColumnName("Saturacion_O2");
            entity.Property(e => e.SintomasCriticosJson).HasColumnName("Sintomas_Criticos_JSON");
            entity.Property(e => e.Temperatura).HasColumnType("decimal(4, 1)");
            entity.Property(e => e.TiempoEvolucion).HasColumnName("Tiempo_Evolucion");

            entity.HasOne(d => d.IdNivelAsignadoNavigation).WithMany(p => p.RegistrosTriajes)
                .HasForeignKey(d => d.IdNivelAsignado)
                .HasConstraintName("FK__Registros__ID_Ni__534D60F1");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.RegistrosTriajes)
                .HasForeignKey(d => d.IdPaciente)
                .HasConstraintName("FK__Registros__ID_Pa__5165187F");

            entity.HasOne(d => d.IdUsuarioEnfermeraNavigation).WithMany(p => p.RegistrosTriajeIdUsuarioEnfermeraNavigations)
                .HasForeignKey(d => d.IdUsuarioEnfermera)
                .HasConstraintName("FK__Registros__ID_Us__52593CB8");

            entity.HasOne(d => d.IdUsuarioMedicoNavigation).WithMany(p => p.RegistrosTriajeIdUsuarioMedicoNavigations)
                .HasForeignKey(d => d.IdUsuarioMedico)
                .HasConstraintName("FK__Registros__ID_Us__5535A963");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__DE4431C52EDD7D58");

            entity.HasIndex(e => e.Username, "UQ__Usuarios__536C85E42EC37B50").IsUnique();

            entity.HasIndex(e => e.DuiUsuaio, "UQ__Usuarios__E76844111815A375").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DuiUsuaio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DUI_Usuaio");
            entity.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Password_Hash");
            entity.Property(e => e.Rol)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
