using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    class Verzekering
    {
        [Key]
        public string VerzekeringNaam { get; set; }
        public int VerzekeringID { get; set; }
        public List<Klanten> Klanten { get; set; }
    }
}
