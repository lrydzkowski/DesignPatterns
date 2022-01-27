namespace DesignPatterns.Types.Models;

internal class AnswersCounter
{
    public int NumOfCorrectAnswers { get; set; } = 0;

    public int NumOfRequiredAnswers { get; init; } = 0;

    public bool Result
    {
        get
        {
            return NumOfCorrectAnswers == NumOfRequiredAnswers;
        }
    }
}
