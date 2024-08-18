using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FarmAnimalTrackingSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FarmAnimalTrackingSystemDB;Trusted_Connection=true");
        }
        public DbSet<Cow> Cows { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Illness> Illnesses { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<CowIllness> CowIllnesses { get; set; }
        public DbSet<CowVaccine> CowVaccines { get; set; }
        public DbSet<CowMedicine> CowMedicines { get; set; }
        public DbSet<CowEstrusPeriod> CowEstrusPeriods { get; set; }
    }
}
