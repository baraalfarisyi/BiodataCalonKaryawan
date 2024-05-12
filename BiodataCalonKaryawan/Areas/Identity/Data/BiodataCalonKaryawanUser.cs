using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BiodataCalonKaryawan.Models;
using Microsoft.AspNetCore.Identity;

namespace BiodataCalonKaryawan.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BiodataCalonKaryawanUser class
public class BiodataCalonKaryawanUser : IdentityUser<Guid>
{
    public virtual Pelamar Pelamar { get; set; }
}

public class ApplicationRole : IdentityRole<Guid>
{
}

