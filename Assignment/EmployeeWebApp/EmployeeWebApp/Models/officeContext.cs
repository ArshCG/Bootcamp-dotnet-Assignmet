using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeWebApp.Models
{
    public partial class officeContext : DbContext
    {
        public officeContext()
        {
        }

        public officeContext(DbContextOptions<officeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=office;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("employee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpGender)
                    .HasColumnName("emp_gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasColumnName("emp_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPos)
                    .IsRequired()
                    .HasColumnName("emp_pos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpProject)
                    .HasColumnName("emp_project")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
