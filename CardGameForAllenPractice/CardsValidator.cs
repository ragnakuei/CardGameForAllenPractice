using System.Collections.Generic;

namespace CardGameForAllenPractice
{
    public interface CardsValidator
    {
        bool TryGetResult(List<Card> card, out CardsResult result);
    }

    public enum CardsResult
    {
        NoResult
    }
}
