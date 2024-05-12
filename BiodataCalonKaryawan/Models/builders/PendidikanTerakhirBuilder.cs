using BiodataCalonKaryawan.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiodataCalonKaryawan.Models.builders
{
    public class PendidikanTerakhirBuilder : IEntityTypeConfiguration<PendidikanTerakhir>
    {
        private readonly DBContextSample _dBContextSample;
        public PendidikanTerakhirBuilder(DBContextSample dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }

        public void Configure(EntityTypeBuilder<PendidikanTerakhir> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.PelamarId)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.Jenjang)
                .HasMaxLength(160);

            builder
                .Property(c => c.NamaInstitusi)
                .HasMaxLength(160);

            builder
                .Property(c => c.Jurusan)
                .HasMaxLength(160);

            builder
                .Property(p => p.TahunLulus)
                .HasDefaultValue("1900-01-01");

            builder
                .Property(c => c.IPK)
                .HasMaxLength(160);

            builder
               .HasOne(c => c.Pelamar)
               .WithMany(c => c.PendidikanTerakhirs)
               .HasForeignKey(c => c.PelamarId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_PendidikanTerakhir_Pelamar");
        }
    }
}
