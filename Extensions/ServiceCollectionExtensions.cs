using ChemistryQuiz.Interfaces.RepositoryInterfaces;
using ChemistryQuiz.Interfaces.ServiceInterfaces;
using ChemistryQuiz.Repositories;
using ChemistryQuiz.Services;

namespace ChemistryQuiz.Extensions;

// Registers application services and repositories.
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Repositories: interface → implementation
        services.AddScoped<IQuestionRepository, QuestionRepository>();

        // Services: interface → implementation
        services.AddScoped<IQuestionService, QuestionService>();

        return services;
    }
}
