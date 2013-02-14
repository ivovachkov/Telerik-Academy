using System;

class DeckOfCards
{
    static void Main()
    {
        string suits = "";
        string ranks = "";

        for (int suit = 0; suit < 4; suit++)
        {
            switch (suit)
            {
                case 0:
                    suits = "Clubs ♣";
                    break;
                case 1:
                    suits = "Diamonds ♦";
                    break;
                case 2:
                    suits = "Hearts ♥";
                    break;
                case 3:
                    suits = "Spades ♠";
                    break;
                default:
                    break;
            }
            
            for (int rank = 1; rank <= 13; rank++)
            {
                switch (rank)
                {
                    case 1:
                        ranks = "Ace";
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        ranks = Convert.ToString(rank);
                        break;
                    case 11:
                        ranks = "Jack";
                        break;
                    case 12:
                        ranks = "Queen";
                        break;
                    case 13:
                        ranks = "King";
                        break;
                    default:
                        break;
                }
                Console.Write("{0,5} of ", ranks);
                Console.WriteLine(suits);
            }
            Console.WriteLine();
        }
    }
}