namespace DesignPatterns.Types.Models.EntryResult;

public abstract class EntryResultAbstract
{
    protected EntryResultAbstract(Entry entry)
    {
        Entry = entry;
    }

    public abstract bool Result { get; }

    public Entry Entry { get; }
}
