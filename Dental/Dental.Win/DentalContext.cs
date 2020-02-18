using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Dental.Core;

namespace Dental.Win
{
    public class DentalContext : DbContext
    {
        public DentalContext() : base("Dental")
        {
        }

        public DentalContext(DbCompiledModel model) : base(model)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationImage> MedicationImages { get; set; }
    }
}
