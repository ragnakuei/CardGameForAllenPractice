using System.Collections.Generic;

namespace CardGameForAllenPractice
{
    public class Cards
    {
        private readonly CardsValidator[] _cardsValidators;

        public Cards(params CardsValidator[] cardsValidators)
        {
            _cardsValidators = cardsValidators;
        }

        public CardsResult Get(List<Card> card)
        {
            foreach (var cardsValidator in _cardsValidators)
            {
                if (cardsValidator.TryGetResult(card, out var result))
                {
                    return result;
                }
            }

            return CardsResult.NoResult;
        }
    }

    public class Card
    {
    }
}
