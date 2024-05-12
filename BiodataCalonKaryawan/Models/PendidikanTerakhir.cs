namespace BiodataCalonKaryawan.Models
{
    public class PendidikanTerakhir
    {
        public Guid Id { get; set; }
        public Guid PelamarId { get; set; }
        public string Jenjang {  get; set; }
        public string NamaInstitusi { get; set; }
        public string Jurusan { get; set; }
        public DateTime TahunLulus { get; set; }
        public string IPK { get; set; }
        public virtual Pelamar? Pelamar { get; set; }
    }
}
