using BiodataCalonKaryawan.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiodataCalonKaryawan.Models.builders
{
    public class RiwayatPelatihanBuilder : IEntityTypeConfiguration<RiwayatPelatihan>
    {
        private readonly DBContextSample _dBContextSample;
        public RiwayatPelatihanBuilder(DBContextSample dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }

        public void Configure(EntityTypeBuilder<RiwayatPelatihan> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.PelamarId)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.NamaKursus)
                .HasMaxLength(160);

            builder
                .Property(c => c.Sertifikat)
                .HasConversion<string>()
                .HasMaxLength(10);

            builder
                .Property(p => p.Tahun)
                .HasDefaultValue("1900-01-01");

            builder
               .HasOne(c => c.Pelamar)
               .WithMany(c => c.RiwayatPelatihans)
               .HasForeignKey(c => c.PelamarId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_RiwayatPelatihan_Pelamar");
        }
    }
}
