using Microsoft.EntityFrameworkCore;
using Quizzator.Entity;

namespace Quizzator.Persistance
{

    public class QuizContext : DbContext
    {
        public DbSet<ThemeExEntity> ThemeEx { get; set; }
        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<ReponseEntity> Reponses { get; set; }
        public DbSet<LinksEntity> Links { get; set; }
        public QuizContext()
        {

        }
        public QuizContext(DbContextOptions opt):base(opt)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Test; Trusted_Connection=True",
                builder => builder.EnableRetryOnFailure());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThemeExEntity>(eb =>
            {
                eb.HasKey(t => t.Id)
                  .HasName("PrimaryKey_ThemeId");

                eb.Property(t => t.Id)
                  .ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<QuestionEntity>(eb =>
            {
                eb.HasKey(q => q.Id)
                  .HasName("PrimaryKey_QuestionId");
                eb.Property(q => q.Id)
                  .ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ReponseEntity>(eb =>
            {
                eb.HasKey(r => r.Id)
                  .HasName("PrimaryKey_ReponseId");
                eb.Property(q => q.Id)
                  .ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<LinksEntity>(eb =>
            {
                eb.HasKey(l => l.Id)
                  .HasName("PrimaryKey_LinksId");
                eb.Property(q => q.Id)
                  .ValueGeneratedOnAdd();

            });

            


            modelBuilder.Entity<ThemeExEntity>()
                .HasMany(t => t.Questions)
                .WithOne()
                .HasForeignKey(q => q.ThemeId);

            modelBuilder.Entity<QuestionEntity>()
                .HasMany(q => q.ReponseList)
                .WithOne()
                .HasForeignKey(r => r.QuestionId);

            modelBuilder.Entity<ReponseEntity>()
                .HasMany(r => r.Liens)
                .WithOne()
                .HasForeignKey(l => l.ReponseId);


           /*modelBuilder.Entity<LinksEntity>()
                        .HasOne(r => r.Element)
                        .HasForeignKey(r => r.ReponseId);*/


            modelBuilder.Entity<ThemeExEntity>().Navigation(ci => ci.Questions).AutoInclude();
            modelBuilder.Entity<QuestionEntity>().Navigation(ci => ci.ReponseList).AutoInclude();
            modelBuilder.Entity<ReponseEntity>().Navigation(ci => ci.Liens).AutoInclude();
        }

        

    }
}
    
