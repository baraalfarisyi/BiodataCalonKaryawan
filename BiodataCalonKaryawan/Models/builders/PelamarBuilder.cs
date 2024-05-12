using BiodataCalonKaryawan.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiodataCalonKaryawan.Models.builders
{
    public class PelamarBuilder : IEntityTypeConfiguration<Pelamar>
    {
        private readonly DBContextSample _dBContextSample;
        public PelamarBuilder(DBContextSample dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }
        public void Configure(EntityTypeBuilder<Pelamar> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.UserId)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.Name)
                .HasMaxLength(160);

            builder
                .Property(c => c.Posisi)
                .HasMaxLength(160);
            builder
                .Property(c => c.IdNumber)
                .HasMaxLength(16);

            builder
                .Property(c => c.TempatLahir)
                .HasMaxLength(160);

            builder
                .Property(p => p.TanggalLahir)
                .HasDefaultValue("1900-01-01");

            builder
                .Property(c => c.Agama)
                .HasMaxLength(50);

            builder
                .Property(c => c.GolDarah)
                .HasConversion<string>()
                .HasMaxLength(10);

            builder
                .Property(c => c.Status)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder
                .Property(c => c.AlamatKTP)
                .HasMaxLength(160);

            builder
                .Property(c => c.AlamatDomisili)
                .HasMaxLength(160);

            builder
                .Property(c => c.Email)
                .HasMaxLength(50);

            builder
                .Property(c => c.TelpNo)
                .HasMaxLength(50);

            builder
                .Property(c => c.Gender)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder
                .Property(c => c.EmergencyName)
                .HasMaxLength(50);

            builder
                .Property(c => c.EmergencyNo)
                .HasMaxLength(50);

            builder
                .Property(c => c.PendapatanHarapan)
                .HasMaxLength(160);

            builder
                .Property(c => c.BersediaDitempatkan)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder
                .HasOne(x => x.BiodataCalonKaryawanUser)
                .WithOne(x => x.Pelamar)
                .HasForeignKey<Pelamar>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        
        }
    }
}
