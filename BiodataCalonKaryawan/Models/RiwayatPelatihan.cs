using BiodataCalonKaryawan.Models.enums;

namespace BiodataCalonKaryawan.Models
{
    public class RiwayatPelatihan
    {
        public Guid Id { get; set; }
        public Guid PelamarId { get; set; }
        public string NamaKursus { get; set; }
        public Sertifikat Sertifikat { get; set; }
        public DateTime Tahun { get; set; }
        public virtual Pelamar? Pelamar { get; set; }
    }
}
