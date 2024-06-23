namespace BlackClient
{
    public class Parser
    {
        public List<Card> ParseCard(string text)
        {
            int start = text.IndexOf("(")+1;//+ 5
            int i = 0;
            const char nullChar = '\0';
            var cards = new List<Card>();
            foreach(char t in text)
                //(text[i] != nullChar)
            {

                if (t == ';')
                {
                    var c = text.Substring(start,i - start);
                    cards.Add(StringtoCard(c));
                    start = i+1;
                }
                i++;
            }
            return cards;
        }

        private Card StringtoCard(string text)
        {
            Face face = new Face();
            if (text.IndexOf("Ace") != -1) face = Face.Ace;
            else if (text.IndexOf("Two") != -1) face = Face.Two;
            else if (text.IndexOf("Three") != -1) face = Face.Three;
            else if (text.IndexOf("Four") != -1) face = Face.Four;
            else if (text.IndexOf("Five") != -1) face = Face.Five;
            else if (text.IndexOf("Six") != -1) face = Face.Six;
            else if (text.IndexOf("Seven") != -1) face = Face.Seven;
            else if (text.IndexOf("Eight") != -1) face = Face.Eight;
            else if (text.IndexOf("Nine") != -1) face = Face.Nine;
            else if (text.IndexOf("Ten") != -1) face = Face.Ten;
            else if (text.IndexOf("Jack") != -1) face = Face.Jack;
            else if (text.IndexOf("Queen") != -1) face = Face.Queen;
            else if (text.IndexOf("King") != -1) face = Face.King;

            Suit suit = new Suit();
            if (text.IndexOf("Diamond") != -1) suit = Suit.Diamonds;
            else if (text.IndexOf("Heart") != -1) suit = Suit.Hearts;
            else if (text.IndexOf("Spade") != -1) suit = Suit.Spades;
            else if (text.IndexOf("Club") != -1) suit = Suit.Clubs;

            return new Card(suit, face);
        }
    }
}
