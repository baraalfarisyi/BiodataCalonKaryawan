using BiodataCalonKaryawan.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiodataCalonKaryawan.Models.builders
{
    public class RiwayatPekerjaanBuilder : IEntityTypeConfiguration<RiwayatPekerjaan>
    {
        private readonly DBContextSample _dBContextSample;
        public RiwayatPekerjaanBuilder(DBContextSample dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }

        public void Configure(EntityTypeBuilder<RiwayatPekerjaan> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.PelamarId)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.NamaPerusahan)
                .HasMaxLength(160);

            builder
                .Property(c => c.Posisi)
                .HasMaxLength(160);

            builder
                .Property(c => c.PendapatanTerakhir)
                .HasMaxLength(160);

            builder
                .Property(p => p.TahunMasuk)
                .HasDefaultValue("1900-01-01");

            builder
                .Property(p => p.TahunKeluar)
                .HasDefaultValue("1900-01-01");

            builder
               .HasOne(c => c.Pelamar)
               .WithMany(c => c.RiwayatPekerjaans)
               .HasForeignKey(c => c.PelamarId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_RiwayatPekerjaan_Pelamar");
        }
    }
}
