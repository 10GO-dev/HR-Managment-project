using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace H_Resource.Models;

public partial class HrmsDbContext : DbContext
{
    public HrmsDbContext()
    {
    }

    public HrmsDbContext(DbContextOptions<HrmsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CountryModel> Countries { get; set; }

    public virtual DbSet<DepartmentModel> Departments { get; set; }

    public virtual DbSet<EmployeeModel> Employees { get; set; }

    public virtual DbSet<GenderModel> Genders { get; set; }

    public virtual DbSet<PayrollModel> Payrolls { get; set; }

    public virtual DbSet<UserModel> Users { get; set; }

    public virtual DbSet<VacationModel> Vacations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:hresource.database.windows.net,1433;Initial Catalog=HRMS_db;Persist Security Info=False;User ID=hradmin;Password=Hr3s0urc3s;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CountryModel>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepartmentModel>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCDF08DEFFF");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmployeeModel>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__tmp_ms_x__7AD04FF16BCF9342");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HireDate).HasColumnType("date");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Employees_Department");

            entity.HasOne(d => d.EmployeeNavigation).WithOne(p => p.Employee)
                .HasForeignKey<EmployeeModel>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_Country");

            entity.HasOne(d => d.Employee1).WithOne(p => p.Employee)
                .HasForeignKey<EmployeeModel>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_Gender");
        });

        modelBuilder.Entity<GenderModel>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollModel>(entity =>
        {
            entity.HasKey(e => e.PayrollId).HasName("PK__Payroll__99DFC69208A96E01");

            entity.ToTable("Payroll");

            entity.Property(e => e.PayrollId)
                .ValueGeneratedNever()
                .HasColumnName("PayrollID");
            entity.Property(e => e.BaseSalary).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Deductions).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.ExitDate).HasColumnType("date");
            entity.Property(e => e.Perks).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.Payrolls)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Payroll__Employe__6EF57B66");
        });

        modelBuilder.Entity<UserModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__1788CCAC6F639A37");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VacationModel>(entity =>
        {
            entity.HasKey(e => e.VacationId).HasName("PK__Vacation__E420DF8425837AC9");

            entity.Property(e => e.VacationId)
                .ValueGeneratedNever()
                .HasColumnName("VacationID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.Employee).WithMany(p => p.Vacations)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Vacations__Emplo__6C190EBB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
