using ChemistryQuiz.Models;

namespace ChemistryQuiz.Interfaces.ServiceInterfaces;

public interface IQuestionService
{
    Task<IEnumerable<Question>> GetQuestionByLevel(QuestionLevel level);
}
