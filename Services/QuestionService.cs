using ChemistryQuiz.Interfaces.RepositoryInterfaces;
using ChemistryQuiz.Interfaces.ServiceInterfaces;
using ChemistryQuiz.Models;

namespace ChemistryQuiz.Services;


public class QuestionService(IQuestionRepository repo) : IQuestionService
{
    public Task<IEnumerable<Question>> GetQuestionByLevel(QuestionLevel level)
    {
        return repo.GetQuestionByLevel(level);
    }
}
