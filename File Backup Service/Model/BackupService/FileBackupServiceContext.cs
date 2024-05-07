using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace File_Backup_Service.Model.BackupService;

public partial class FileBackupServiceContext : DbContext
{
    public FileBackupServiceContext()
    {
    }

    public FileBackupServiceContext(DbContextOptions<FileBackupServiceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FileDirectory> FileDirectories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IHC6K02\\MSSQLSERVER01;Initial Catalog=FileBackupService;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FileDirectory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FileDire__3214EC2719E514EF");

            entity.ToTable("FileDirectory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
