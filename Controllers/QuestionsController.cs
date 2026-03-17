using Microsoft.AspNetCore.Mvc;
using ChemistryQuiz.Interfaces.ServiceInterfaces;
using ChemistryQuiz.Models;

namespace ChemistryQuiz.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionService _questionService;

    public QuestionsController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet("level/{level}")]
    public async Task<IActionResult> GetQuestionByLevel(QuestionLevel level = QuestionLevel.One)
    {
        var questions = await _questionService.GetQuestionByLevel(level);
        return Ok(questions);
    }
}
