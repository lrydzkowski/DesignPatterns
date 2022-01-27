namespace DesignPatterns.Types.Models.EntryResult;

internal class OnlyOpenEntryResult : EntryResultAbstract
{
    public OnlyOpenEntryResult(Entry entry) : base(entry)
    {
        WordAnswersCounter = new() { NumOfRequiredAnswers = 2 };
        TranslationAnswersCounter = new() { NumOfRequiredAnswers = 2 };
    }

    public override bool Result
    {
        get
        {
            return WordAnswersCounter.Result && TranslationAnswersCounter.Result;
        }
    }

    public AnswersCounter WordAnswersCounter { get; }

    public AnswersCounter TranslationAnswersCounter { get; }
}
