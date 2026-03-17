using ChemistryQuiz.Interfaces.RepositoryInterfaces;
using ChemistryQuiz.Interfaces.ServiceInterfaces;
namespace ChemistryQuiz.Services;


public class QuestionService(IQuestionRepository repo) : IQuestionService
{
}
