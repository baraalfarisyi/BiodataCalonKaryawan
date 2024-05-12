using BiodataCalonKaryawan.Areas.Identity.Data;
using BiodataCalonKaryawan.Models.enums;
using Microsoft.AspNetCore.Identity;

namespace BiodataCalonKaryawan.Models
{
    public class Pelamar
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
        public virtual BiodataCalonKaryawanUser BiodataCalonKaryawanUser { get; set; }
        public virtual List<PendidikanTerakhir> PendidikanTerakhirs { get; set; } = new();
        public virtual List<RiwayatPekerjaan> RiwayatPekerjaans { get; set; } = new();
        public virtual List<RiwayatPelatihan> RiwayatPelatihans { get; set; } = new();
    }
}
