namespace Home_Study.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WidgetContext : DbContext
    {
        public WidgetContext()
            : base("name=WidgetConnection")
        {
        }

        public virtual DbSet<Widget> Widgets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Widget>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Widget>()
                .Property(e => e.PartNum)
                .IsFixedLength();
        }
    }
}
