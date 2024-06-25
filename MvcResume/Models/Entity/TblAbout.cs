namespace MvcResume.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblAbout
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string Fotograf { get; set; }
    }
}
