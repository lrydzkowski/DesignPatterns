namespace DesignPatterns.Types.Models.EntryResult;

internal class FullEntryResult : EntryResultAbstract
{
    public FullEntryResult(Entry entry) : base(entry)
    {
        ClosedWordAnswersCounter = new() { NumOfRequiredAnswers = 1 };
        ClosedTranslationAnswersCounter = new() { NumOfRequiredAnswers = 1 };
        OpenWordAnswersCounter = new() { NumOfRequiredAnswers = 2 };
        OpenTranslationAnswersCounter = new() { NumOfRequiredAnswers = 2 };
    }

    public override bool Result
    {
        get
        {
            return ClosedWordAnswersCounter.Result
                && ClosedTranslationAnswersCounter.Result
                && OpenWordAnswersCounter.Result
                && OpenTranslationAnswersCounter.Result;
        }
    }

    public AnswersCounter ClosedWordAnswersCounter { get; set; }

    public AnswersCounter ClosedTranslationAnswersCounter { get; set; }

    public AnswersCounter OpenWordAnswersCounter { get; }

    public AnswersCounter OpenTranslationAnswersCounter { get; }
}
