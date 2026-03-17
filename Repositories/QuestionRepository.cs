using ChemistryQuiz.Data;
using ChemistryQuiz.Interfaces.RepositoryInterfaces;

namespace ChemistryQuiz.Repositories;

public class QuestionRepository(ChemistryQuizDbContext db) : IQuestionRepository
{
}
