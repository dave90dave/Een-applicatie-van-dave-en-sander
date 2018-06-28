using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    class database : DbContext
    {
        public DbSet<Klanten> klanten { get; set; }
        public DbSet<Medicatie> medicatie { get; set; }
        public DbSet<Arts> arts { get; set; }
        public DbSet<Verzekering> verzekering { get; set; }
        public DbSet<KlantenMedicatie> KlantenMedicatie { get; set; }
    }
}
