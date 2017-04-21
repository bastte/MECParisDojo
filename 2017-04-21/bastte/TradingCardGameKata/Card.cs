namespace TradingCardGameKata
{
    public class Card
    {
        public int ManaCost { get; }

        public Card(int manaCost)
        {
            ManaCost = manaCost;
        }

        public override bool Equals(object obj)
        {
            var cardObj = obj as Card;
            if (cardObj == null)
            {
                return false;
            }
            return cardObj.ManaCost == ManaCost;
        }
    }
}