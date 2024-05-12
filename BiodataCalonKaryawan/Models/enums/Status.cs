using System.ComponentModel;

namespace BiodataCalonKaryawan.Models.enums
{
    public enum Status
    {
        [Description("KAWIN")]
        Kawin,
        [Description("BELUM KAWIN")]
        BelumKawin,
        [Description("CERAI HIDUP")]
        CeraiHidup,
        [Description("CERAI MATI")]
        CeraiMati,
        [Description("PISAH")]
        Pisah,
        [Description("HIDUP BERSAMA")]
        HidupBersama
    }
}
