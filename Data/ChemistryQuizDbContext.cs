using ChemistryQuiz.Models;
using Microsoft.EntityFrameworkCore;

namespace ChemistryQuiz.Data;

public class ChemistryQuizDbContext : DbContext
{
    public ChemistryQuizDbContext(DbContextOptions<ChemistryQuizDbContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions => Set<Question>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasMany(q => q.Answers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
