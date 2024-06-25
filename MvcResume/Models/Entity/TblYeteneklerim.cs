namespace MvcResume.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblYeteneklerim
    {
        public int ID { get; set; }
        public string Yetenek { get; set; }
        public Nullable<byte> Oran { get; set; }
    }
}
