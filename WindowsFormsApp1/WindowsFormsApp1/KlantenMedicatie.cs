using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class KlantenMedicatie
    {
        [Key]
        public int MedicatieID { get; set; }
        public int KlantID { get; set; }
        public virtual Klanten Klanten { get; set; }
        public virtual Medicatie Medicatie { get; set; }

    }
}
