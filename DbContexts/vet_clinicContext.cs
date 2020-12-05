using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClinicApp.Models;
using System.Configuration;

namespace ClinicApp.DbContexts
{
    public partial class vet_clinicContext : DbContext
    {
        public vet_clinicContext()
        {
        }

        public vet_clinicContext(DbContextOptions<vet_clinicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<AnimalsVactination> AnimalsVactination { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<OwnersServices> OwnersServices { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<UsersPass> UsersPass { get; set; }
        public virtual DbSet<Vactination> Vactination { get; set; }
        public virtual DbSet<Veterinarian> Veterinarian { get; set; }
  
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString, x => x.ServerVersion("8.0.22-mysql"));
            }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animals>(entity =>
            {
                entity.ToTable("animals");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("animals_owners_id_fk");

                entity.HasIndex(e => e.VeterinarianId)
                    .HasName("animals_veterinarian_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AnimalName)
                    .IsRequired()
                    .HasColumnName("animal_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Breed)
                    .IsRequired()
                    .HasColumnName("breed")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.VeterinarianId).HasColumnName("veterinarian_id");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("animals_owners_id_fk");

                entity.HasOne(d => d.Veterinarian)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.VeterinarianId)
                    .HasConstraintName("animals_veterinarian_id_fk");
            });

            modelBuilder.Entity<AnimalsVactination>(entity =>
            {
                entity.ToTable("animals_vactination");

                entity.HasIndex(e => e.AnimalId)
                    .HasName("animals_vactination_animals_id_fk");

                entity.HasIndex(e => e.VactinationId)
                    .HasName("animals_vactination_vactination_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnimalId).HasColumnName("animal_id");

                entity.Property(e => e.VactinationId).HasColumnName("vactination_id");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalsVactination)
                    .HasForeignKey(d => d.AnimalId)
                    .HasConstraintName("animals_vactination_animals_id_fk");

                entity.HasOne(d => d.Vactination)
                    .WithMany(p => p.AnimalsVactination)
                    .HasForeignKey(d => d.VactinationId)
                    .HasConstraintName("animals_vactination_vactination_id_fk");
            });

            modelBuilder.Entity<Owners>(entity =>
            {
                entity.ToTable("owners");

                entity.HasIndex(e => e.Phone)
                    .HasName("owners_phone_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OwnerLastname)
                    .IsRequired()
                    .HasColumnName("owner_lastname")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasColumnName("owner_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OwnerSurname)
                    .IsRequired()
                    .HasColumnName("owner_surname")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<OwnersServices>(entity =>
            {
                entity.ToTable("owners_services");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("owners_services_owners_id_fk");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("owners_services_services_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.OwnersServices)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("owners_services_owners_id_fk");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.OwnersServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("owners_services_services_id_fk");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.ToTable("services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasColumnName("service_name")
                    .HasColumnType("varchar(70)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<UsersPass>(entity =>
            {
                entity.ToTable("users_pass");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Vactination>(entity =>
            {
                entity.ToTable("vactination");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.VactinationName)
                    .IsRequired()
                    .HasColumnName("vactination_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Veterinarian>(entity =>
            {
                entity.ToTable("veterinarian");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VeterinarianLastname)
                    .IsRequired()
                    .HasColumnName("veterinarian_lastname")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VeterinarianName)
                    .IsRequired()
                    .HasColumnName("veterinarian_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VeterinarianSurname)
                    .IsRequired()
                    .HasColumnName("veterinarian_surname")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
