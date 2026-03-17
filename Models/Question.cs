namespace ChemistryQuiz.Models;

// ---- All Question-related types in one file (like one Laravel model + casts + enums) ----

/// <summary>
/// Difficulty level (1 = easiest, 10 = hardest). Stored as int in DB.
/// </summary>
public enum QuestionLevel
{
    One = 1, Two = 2, Three = 3, Four = 4, Five = 5,
    Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Eleven = 11
}

/// <summary>
/// One answer option. Many of these belong to one Question (one-to-many).
/// </summary>
public class QuestionAnswerOption
{
    public int Id { get; set; }
    public int QuestionId { get; set; }  // FK: "many" side
    public string Key { get; set; } = string.Empty;   // e.g. "A", "B"
    public string Value { get; set; } = string.Empty; // answer text
    public bool IsCorrect { get; set; }

    public Question? Question { get; set; }  // nav back to the "one" (optional, no = new())
}

/// <summary>
/// Question entity. One question has 4 suggested answers (one-to-many).
/// </summary>
public class Question
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public QuestionLevel Level { get; set; }

    public List<QuestionAnswerOption> Answers { get; set; } = new();  // "one" side has the collection
}
