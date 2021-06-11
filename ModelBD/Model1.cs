using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Регистратура_поликлиники.ModelBD
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model16")
        {
        }

        public virtual DbSet<Регистратура> Регистратура { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
