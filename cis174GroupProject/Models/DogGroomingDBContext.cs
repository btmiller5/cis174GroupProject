using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cis174GroupProject.Models
{
    public partial class DogGroomingDBContext : DbContext
    {
        public DogGroomingDBContext()
        {
        }

        public DogGroomingDBContext(DbContextOptions<DogGroomingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DogGroomingDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animals>(entity =>
            {
                entity.HasKey(e => e.AnimalId)
                    .HasName("PK__Animals__68745631F4BAB5DB");

                entity.Property(e => e.AnimalId).HasColumnName("animalID");

                entity.Property(e => e.Breed)
                    .IsRequired()
                    .HasColumnName("breed")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.PetType)
                    .IsRequired()
                    .HasColumnName("petType")
                    .HasMaxLength(50);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK__Bookings__D067651E1E736F28");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentID");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointmentDate")
                    .HasColumnType("date");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.OwnerName).HasColumnName("ownerName");

                entity.Property(e => e.PetId).HasColumnName("petID");

                entity.Property(e => e.PetName)
                    .HasColumnName("petName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Owners>(entity =>
            {
                entity.HasKey(e => e.OwnerId)
                    .HasName("PK__Owners__7E4B716C1EF755D9");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PayMethod)
                    .HasColumnName("payMethod")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Credit/Debit')");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
