using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WindowsFormsApp1
{
    class KlantenVerzekering
    {
        [Key]
        public int VerzekeringID { get; set; }
        public string VerzekeringNaam { get; set; }
        public int KlantID { get; set; }
        public List<Klanten> Klanten { get; set; }
    }
}
