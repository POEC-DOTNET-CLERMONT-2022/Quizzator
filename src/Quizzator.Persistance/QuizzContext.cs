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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test; Trusted_Connection=True",
                builder => builder.EnableRetryOnFailure());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThemeExEntity>(eb =>
            {
                eb.HasKey(t => t._Id)
                  .HasName("PrimaryKey_ThemeId");

                eb.Property(t => t._Id)
                  .ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<QuestionEntity>(eb =>
            {
                eb.HasKey(q => q._Id)
                  .HasName("PrimaryKey_QuestionId");
                eb.Property(q => q._Id)
                  .ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ReponseEntity>(eb =>
            {
                eb.HasKey(r => r._Id)
                  .HasName("PrimaryKey_ReponseId");
                eb.Property(q => q._Id)
                  .ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<LinksEntity>(eb =>
            {
                eb.HasKey(l => l._Id)
                  .HasName("PrimaryKey_LinksId");
                eb.Property(q => q._Id)
                  .ValueGeneratedOnAdd();

            });


            modelBuilder.Entity<ThemeExEntity>()
                .HasMany(q => q._Questions);
            modelBuilder.Entity<QuestionEntity>()
                .HasMany(r => r._ReponseList);
            modelBuilder.Entity<LinksEntity>()
                        .HasOne(r => r.Reponse)
                        .WithMany(l => l._Lien)
                        .HasForeignKey("Links")
                        .HasConstraintName("Link_In_Response");
            modelBuilder.Entity<ReponseEntity>()
                         .HasOne(q => q.Question)
                         .WithMany(l => l._ReponseList)
                         .HasForeignKey("Reponse")
                         .HasConstraintName("Reponses_In_Question");
            modelBuilder.Entity<QuestionEntity>()
                         .HasOne(t => t.ThemeEx)
                         .WithMany(q => q._Questions)
                         .HasForeignKey("Question")
                         .HasConstraintName("Question_In_Theme");
        }

    }
}
    
