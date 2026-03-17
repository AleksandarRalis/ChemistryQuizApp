using ChemistryQuiz.Models;

namespace ChemistryQuiz.Interfaces.RepositoryInterfaces;

public interface IQuestionRepository
{
    Task<IEnumerable<Question>> GetQuestionByLevel(QuestionLevel level);
}
