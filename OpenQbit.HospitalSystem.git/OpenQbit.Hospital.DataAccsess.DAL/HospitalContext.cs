using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.Common.Models.Management;
using OpenQbit.Hospital.Common.Models.OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.Common.Models.Phamarcy;
using OpenQbit.Hospital.Common.Models.Phamarcy.OpenQbit.Hospital.Common.Models.Phamarcy;
using OpenQbit.Hospital.Common.Models.Ward;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.DataAccsess.DAL
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("HospitalDataBase")
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

        public System.Data.Entity.DbSet<OpenQbit.Hospital.Common.Models.Doctor> Doctors { get; set; }

        public System.Data.Entity.DbSet<OpenQbit.Hospital.Common.Models.Management.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<OpenQbit.Hospital.Common.Models.Ward.Ward> Wards { get; set; }

        public System.Data.Entity.DbSet<OpenQbit.Hospital.Common.Models.WardType> WardTypes { get; set; }

        public System.Data.Entity.DbSet<OpenQbit.Hospital.Common.Models.Person> People { get; set; }

        public DbSet<RoomDetails> RoomDetails { get; set; }
        public DbSet<Treatment> Treatment { get; set; }

        public DbSet<WardAdmition> WardAdmition { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Attendance> Attendance { get; set; }

        public DbSet<Salary> Salary { get; set; }

        public DbSet<Person> Person { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
