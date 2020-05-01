namespace DeckOfCardsApp
{
    public class Card
    {
        public string MyProperty { get; private set; }

        public ESuite Suite { get; set; }

        public int Value { get; set; }

        public string ValueToString()
        {
            switch (Value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return Value.ToString();
            }
        }
    }
}
