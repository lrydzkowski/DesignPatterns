using DesignPatterns.Types.Models.EntryResult;

namespace DesignPatterns.Types.Services;

public interface IEntryRandom<T> where T : EntryResultAbstract
{
    public IEnumerable<T> GetNext();
}
