namespace MvcResume.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblIletisim
    {
        public int ID { get; set; }
        public string Adsoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
