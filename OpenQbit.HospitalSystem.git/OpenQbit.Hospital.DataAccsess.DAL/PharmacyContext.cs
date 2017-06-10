using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.Common.Models.Phamarcy;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.DataAccsess.DAL
{
   public class PharmacyContext : DbContext
    {
        public PharmacyContext() : base("PharmacyDataBase")
        {
            this.Configuration.ProxyCreationEnabled = false;

        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientAdmition> PatientAdmition { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Drug> Drug { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PharmacyOrders> PharmacyOrders { get; set; }
        public DbSet<PharmacyOrdersDetail> PharmacyOrdersDetail { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
