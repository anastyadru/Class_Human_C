using System;

namespace Class_Human_C
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Human> Humans { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext>options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

//