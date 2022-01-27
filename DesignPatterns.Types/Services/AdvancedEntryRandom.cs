using DesignPatterns.Types.Extensions;
using DesignPatterns.Types.Models.EntryResult;

namespace DesignPatterns.Types.Services;

public class AdvancedEntryRandom<T> : IEntryRandom<T> where T : EntryResultAbstract
{
    public AdvancedEntryRandom(List<T> entries)
    {
        Entries = entries;
        Entries.Shuffle();
    }

    private List<T> Entries { get; } = new();

    private Random Random { get; } = new();

    public IEnumerable<T> GetNext()
    {
        int previousIndex = -1;
        while (Entries.Any(entry => !entry.Result))
        {
            int index = GetNextIndex(previousIndex);
            yield return Entries[index];
            previousIndex = index;
        }
    }

    private int GetNextIndex(int previousIndex = -1)
    {
        if (Entries.Count <= 1)
        {
            return 0;
        }
        int index;
        do
        {
            index = Random.Next(0, Entries.Count);
        }
        while (index == previousIndex);
        return index;
    }
}
