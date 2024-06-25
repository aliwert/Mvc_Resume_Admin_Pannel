namespace MvcResume.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblAdmin
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
