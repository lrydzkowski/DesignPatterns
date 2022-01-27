namespace DesignPatterns.Types.Models.EntryResult;

internal class SpellingEntryResult : EntryResultAbstract
{
    public SpellingEntryResult(Entry entry) : base(entry)
    {
        AnswersCounter = new() { NumOfRequiredAnswers = 2 };
    }

    public override bool Result
    {
        get
        {
            return AnswersCounter.Result;
        }
    }

    public AnswersCounter AnswersCounter { get; }
}
