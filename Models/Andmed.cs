using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class Andmed
    {
        public string Nimi { get; set; }
        public DateTime? SNniaeg { get; set; }
        public string Linn { get; set; }
        public string Aadress { get; set; }
        public string Telefon { get; set; }
        public bool Elus { get; set; }
        public string Palk { get; set; }
        public string Surnud { get; set; }
        public string Sugu { get; set; }
    }
}
