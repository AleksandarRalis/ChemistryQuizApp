using ChemistryQuiz.Data;
using ChemistryQuiz.Interfaces.RepositoryInterfaces;
using ChemistryQuiz.Models;
using Microsoft.EntityFrameworkCore;

namespace ChemistryQuiz.Repositories;

public class QuestionRepository(ChemistryQuizDbContext db) : IQuestionRepository
{
    public async Task<IEnumerable<Question>> GetQuestionByLevel(QuestionLevel level)
    {
        return await db.Questions.Where(q => q.Level == level).ToListAsync();
    }
}
