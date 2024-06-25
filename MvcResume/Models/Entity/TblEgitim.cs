namespace MvcResume.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblEgitim
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik1 { get; set; }
        public string AltBaslik2 { get; set; }
        public string GNO { get; set; }
        public string Tarih { get; set; }
    }
}
