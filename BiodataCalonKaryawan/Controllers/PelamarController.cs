using BiodataCalonKaryawan.Areas.Identity.Data;
using BiodataCalonKaryawan.Models;
using BiodataCalonKaryawan.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Policy;


namespace BiodataCalonKaryawan.Controllers
{
    public class PelamarController : Controller
    {
        protected readonly DBContextSample _dbContext;
        private readonly UserManager<BiodataCalonKaryawanUser> _userManager;

        public PelamarController(DBContextSample dbContext, UserManager<BiodataCalonKaryawanUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // GET: PelamarController/Details/5     
        [Route("Pelamar")]
        [HttpGet]
        public async  Task<ActionResult> Index()
        {
           var pelamar = await _dbContext.Pelamars.ToListAsync();
            return View(pelamar);
        }
       
        [HttpGet]
        public ActionResult Insert()
        {
            
            return View();
        }

        // GET: PelamarController/Create
        [Route("Insert")]
        [HttpPost]
        public async Task<ActionResult> Insert(InputPelamar inputPelamar)
        {
            var pelamar = new Pelamar()
            {
                
                    Id = Guid.NewGuid(),
                    UserId = Guid.Parse (User.FindFirstValue(ClaimTypes.NameIdentifier)),
                    Posisi = inputPelamar.Posisi,
                    Name = inputPelamar.Name,
                    IdNumber = inputPelamar.IdNumber,
                    TempatLahir = inputPelamar.TempatLahir,
                    Gender = inputPelamar.Gender,
                    Agama = inputPelamar.Agama,
                    GolDarah = inputPelamar.GolDarah,
                    Status = inputPelamar.Status,
                    AlamatKTP = inputPelamar.AlamatKTP,
                    AlamatDomisili = inputPelamar.AlamatDomisili,
                    Email = inputPelamar.Email,
                    TelpNo = inputPelamar.Email,
                    EmergencyName = inputPelamar.EmergencyName,
                    EmergencyNo = inputPelamar.EmergencyNo,
                    BersediaDitempatkan = inputPelamar.BersediaDitempatkan,
                    PendapatanHarapan = inputPelamar.PendapatanHarapan,
                
            };

            var pendidikanTerakhir = new PendidikanTerakhir()
            {
                Id = Guid.NewGuid(),
                PelamarId = pelamar.Id,
                Jenjang = inputPelamar.InputPendidikanTerakhir.Jenjang,
                NamaInstitusi = inputPelamar.InputPendidikanTerakhir.NamaInstitusi,
                Jurusan = inputPelamar.InputPendidikanTerakhir.Jurusan,
                TahunLulus = inputPelamar.InputPendidikanTerakhir.TahunLulus,
                IPK = inputPelamar.InputPendidikanTerakhir.IPK
            };

            var riwayatPelatihan = new RiwayatPelatihan()
            {
                Id = Guid.NewGuid(),
                PelamarId = pelamar.Id,
                NamaKursus = inputPelamar.InputRiwayatPelatihan.NamaKursus,
                Sertifikat = inputPelamar.InputRiwayatPelatihan.Sertifikat,
                Tahun = inputPelamar.InputRiwayatPelatihan.Tahun
            };

            var riwayatPekerjaan = new RiwayatPekerjaan()
            {
                Id = Guid.NewGuid(),
                PelamarId = pelamar.Id,
                NamaPerusahan = inputPelamar.InputRiwayatPekerjaan.NamaPerusahan,
                Posisi = inputPelamar.InputRiwayatPekerjaan.Posisi,
                PendapatanTerakhir = inputPelamar.InputRiwayatPekerjaan.PendapatanTerakhir,
                TahunMasuk = inputPelamar.InputRiwayatPekerjaan.TahunMasuk,
                TahunKeluar = inputPelamar.InputRiwayatPekerjaan.TahunKeluar
            };

            await _dbContext.Pelamars.AddAsync(pelamar);
            await _dbContext.PendidikanTerakhirs.AddAsync(pendidikanTerakhir);
            await _dbContext.RiwayatPelatihan.AddAsync(riwayatPelatihan);
            await _dbContext.RiwayatPekerjaans.AddAsync(riwayatPekerjaan);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        // GET: PelamarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PelamarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PelamarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PelamarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
