using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<TinhTrang> TinhTrangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhTrang>()
                .HasMany(e => e.BenhNhans)
                .WithRequired(e => e.TinhTrang)
                .WillCascadeOnDelete(false);
        }
    }
}
