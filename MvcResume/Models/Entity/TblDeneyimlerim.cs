namespace MvcResume.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblDeneyimlerim
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
    }
}
