using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FourApplication.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        //Subjects
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Students_Subjects> Students_Subjects { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Nurses> Nurses { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=portal_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins", "hospital_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });
              modelBuilder.Entity<Subjects>(entity =>
            {
                entity.ToTable("subjects", "portal_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
                
                entity.Property(e => e.IsChecked)
                    .HasColumnName("Check")
                    .HasColumnType("tinyint(1)");
            

            });
              modelBuilder.Entity<Students_Subjects>(entity =>
            {
                entity.ToTable("student_subject", "portal_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
                entity.Property(e => e.StudentID)
                    .HasColumnName("studentID")
                    .HasColumnType("int(11)");
                entity.Property(e => e.SubjectID)
                    .HasColumnName("subjectID")
                    .HasColumnType("int(11)");    


            });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.ToTable("doctors", "portal_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Specialist)
                    .IsRequired()
                    .HasColumnName("specialist")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nurses>(entity =>
            {
                entity.ToTable("nurses", "hospital_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.ToTable("patients", "hospital_db");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("doctor_id");

                entity.HasIndex(e => e.NurseId)
                    .HasName("nurse_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HealthCondition)
                    .IsRequired()
                    .HasColumnName("health_condition")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NurseId)
                    .HasColumnName("nurse_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patients_ibfk_1");

                entity.HasOne(d => d.Nurse)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patients_ibfk_2");
            });
        }
    }
}
