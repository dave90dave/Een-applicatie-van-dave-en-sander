using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    class Klanten
    {
        [Key]
        public int KlantID { get; set; }
        public int VerzekeringsID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Plaats { get; set; }
        

    }
}
