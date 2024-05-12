using BiodataCalonKaryawan.Models.enums;

namespace BiodataCalonKaryawan.Models.ViewModels
{
    public class InputPelamar
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Posisi { get; set; }
        public string IdNumber { get; set; }
        public string TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Agama { get; set; }
        public GolDarah GolDarah { get; set; }
        public Status Status { get; set; }
        public string AlamatKTP { get; set; }
        public string AlamatDomisili { get; set; }
        public string Email { get; set; }
        public string TelpNo { get; set; }
        public Gender Gender { get; set; }
        public string EmergencyNo { get; set; }
        public string EmergencyName { get; set; }
        public string PendapatanHarapan { get; set; }
        public BersediaDitempatkan BersediaDitempatkan { get; set; }
        public InputPendidikanTerakhir InputPendidikanTerakhir { get; set; }
        public InputRiwayatPekerjaan InputRiwayatPekerjaan { get; set; }
        public InputRiwayatPelatihan InputRiwayatPelatihan { get; set; }

    }

    public class InputPendidikanTerakhir
    {
        public string Jenjang { get; set; }
        public string NamaInstitusi { get; set; }
        public string Jurusan { get; set; }
        public DateTime TahunLulus { get; set; }
        public string IPK { get; set; }
    }

    public class InputRiwayatPekerjaan
    {
        public string NamaPerusahan { get; set; }
        public string Posisi { get; set; }
        public string PendapatanTerakhir { get; set; }
        public DateTime TahunKeluar { get; set; }
        public DateTime TahunMasuk { get; set; }
    }

    public class InputRiwayatPelatihan
    {
        public string NamaKursus { get; set; }
        public Sertifikat Sertifikat { get; set; }
        public DateTime Tahun { get; set; }
    }
}
