using DesignPatterns.Types.Extensions;
using DesignPatterns.Types.Models.EntryResult;

namespace DesignPatterns.Types.Services;

public class StandardEntryRandom<T> : IEntryRandom<T> where T : EntryResultAbstract
{
    public StandardEntryRandom(List<T> entries)
    {
        Entries = entries;
        Entries.Shuffle();
    }

    protected List<T> Entries { get; } = new();

    public IEnumerable<T> GetNext()
    {
        int index = 0;
        while (Entries.Any(entry => !entry.Result))
        {
            yield return Entries[index];
            index++;
            if (index == Entries.Count)
            {
                index = 0;
            }
        }
    }
}
