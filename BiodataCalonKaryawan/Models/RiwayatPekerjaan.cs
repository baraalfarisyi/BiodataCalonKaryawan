namespace BiodataCalonKaryawan.Models
{
    public class RiwayatPekerjaan
    {
        public Guid Id { get; set; }
        public Guid PelamarId { get; set; }
        public string NamaPerusahan { get; set; }
        public string Posisi { get; set; }
        public string PendapatanTerakhir { get; set; }
        public DateTime TahunKeluar {  get; set; }
        public DateTime TahunMasuk { get; set; }
        public virtual Pelamar? Pelamar { get; set; }
    }
}
