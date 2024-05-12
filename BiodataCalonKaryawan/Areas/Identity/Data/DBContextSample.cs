using BiodataCalonKaryawan.Areas.Identity.Data;
using BiodataCalonKaryawan.Models;
using BiodataCalonKaryawan.Models.builders;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BiodataCalonKaryawan.Areas.Identity.Data;

public class DBContextSample : IdentityDbContext<BiodataCalonKaryawanUser, ApplicationRole, Guid>
{
    public DBContextSample(DbContextOptions<DBContextSample> options)
        : base(options)
    {
    }

    public DbSet<Pelamar> Pelamars => Set<Pelamar>();
    public DbSet<PendidikanTerakhir> PendidikanTerakhirs => Set<PendidikanTerakhir>();
    public DbSet<RiwayatPekerjaan> RiwayatPekerjaans => Set<RiwayatPekerjaan>();
    public DbSet<RiwayatPelatihan> RiwayatPelatihan => Set<RiwayatPelatihan>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        new PelamarBuilder(this).Configure(builder.Entity<Pelamar>());
        new PendidikanTerakhirBuilder(this).Configure(builder.Entity<PendidikanTerakhir>());
        new RiwayatPekerjaanBuilder(this).Configure(builder.Entity<RiwayatPekerjaan>());
        new RiwayatPelatihanBuilder(this).Configure(builder.Entity<RiwayatPelatihan>());
    }
}

