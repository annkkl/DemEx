using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dem
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drivers>()
                .Property(e => e.Middlename)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Patronymic)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.AddressLife)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Jobname)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Photo)
                .IsFixedLength();
        }
    }
}
