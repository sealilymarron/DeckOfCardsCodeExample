using ShiftWiseCodeExercise.Models;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ShiftWiseCodeExerciseUnitTests
{
    [TestFixture]
    public class CardTests
    {
	   /// <summary>
	   /// Cards should display suit and number. In the case of A, J, Q, K, the "Number" should be output as the corresponding name instead. e.g. "Nine of Hearts", "Queen of Spades, "Ace of Diamonds"
	   /// </summary>
	   /// <param name="number"></param>
	   /// <param name="suit"></param>
	   /// <param name="expected"></param>
	   [Test]
	   [TestCaseSource(typeof(FormattedCardNames), "CardNames")]

	   public void CardNameShouldBeFormatted(int number,Card.Suits suit, string expected)
	   {
		  Card testCard = new Card(number, suit);

		  Assert.AreEqual(expected, testCard.ToString());
	   }
    }

	public class FormattedCardNames
	{
		static readonly object[] CardNames =
		{
		    new object[] {1, Card.Suits.Clubs, "Ace of Clubs"},
		    new object[] {2, Card.Suits.Clubs, "Two of Clubs"},
		    new object[] {3, Card.Suits.Clubs, "Three of Clubs"},
		    new object[] {4, Card.Suits.Clubs, "Four of Clubs"},
		    new object[] {5, Card.Suits.Clubs, "Five of Clubs"},
		    new object[] {6, Card.Suits.Clubs, "Six of Clubs"},
		    new object[] {7, Card.Suits.Clubs, "Seven of Clubs"},
		    new object[] {8, Card.Suits.Clubs, "Eight of Clubs"},
		    new object[] {9, Card.Suits.Clubs, "Nine of Clubs"},
		    new object[] {10, Card.Suits.Clubs, "Ten of Clubs"},
		    new object[] {11, Card.Suits.Clubs, "Jack of Clubs"},
		    new object[] {12, Card.Suits.Clubs, "Queen of Clubs"},
		    new object[] {13, Card.Suits.Clubs, "King of Clubs"},
		    new object[] {1, Card.Suits.Diamonds, "Ace of Diamonds"},
		    new object[] {2, Card.Suits.Diamonds, "Two of Diamonds"},
		    new object[] {3, Card.Suits.Diamonds, "Three of Diamonds"},
		    new object[] {4, Card.Suits.Diamonds, "Four of Diamonds"},
		    new object[] {5, Card.Suits.Diamonds, "Five of Diamonds"},
		    new object[] {6, Card.Suits.Diamonds, "Six of Diamonds"},
		    new object[] {7, Card.Suits.Diamonds, "Seven of Diamonds"},
		    new object[] {8, Card.Suits.Diamonds, "Eight of Diamonds"},
		    new object[] {9, Card.Suits.Diamonds, "Nine of Diamonds"},
		    new object[] {10, Card.Suits.Diamonds, "Ten of Diamonds"},
		    new object[] {11, Card.Suits.Diamonds, "Jack of Diamonds"},
		    new object[] {12, Card.Suits.Diamonds, "Queen of Diamonds"},
		    new object[] {13, Card.Suits.Diamonds, "King of Diamonds"},
		    new object[] {1, Card.Suits.Hearts, "Ace of Hearts"},
		    new object[] {2, Card.Suits.Hearts, "Two of Hearts"},
		    new object[] {3, Card.Suits.Hearts, "Three of Hearts"},
		    new object[] {4, Card.Suits.Hearts, "Four of Hearts"},
		    new object[] {5, Card.Suits.Hearts, "Five of Hearts"},
		    new object[] {6, Card.Suits.Hearts, "Six of Hearts"},
		    new object[] {7, Card.Suits.Hearts, "Seven of Hearts"},
		    new object[] {8, Card.Suits.Hearts, "Eight of Hearts"},
		    new object[] {9, Card.Suits.Hearts, "Nine of Hearts"},
		    new object[] {10, Card.Suits.Hearts, "Ten of Hearts"},
		    new object[] {11, Card.Suits.Hearts, "Jack of Hearts"},
		    new object[] {12, Card.Suits.Hearts, "Queen of Hearts"},
		    new object[] {13, Card.Suits.Hearts, "King of Hearts"},
		    new object[] {1, Card.Suits.Spades, "Ace of Spades"},
		    new object[] {2, Card.Suits.Spades, "Two of Spades"},
		    new object[] {3, Card.Suits.Spades, "Three of Spades"},
		    new object[] {4, Card.Suits.Spades, "Four of Spades"},
		    new object[] {5, Card.Suits.Spades, "Five of Spades"},
		    new object[] {6, Card.Suits.Spades, "Six of Spades"},
		    new object[] {7, Card.Suits.Spades, "Seven of Spades"},
		    new object[] {8, Card.Suits.Spades, "Eight of Spades"},
		    new object[] {9, Card.Suits.Spades, "Nine of Spades"},
		    new object[] {10, Card.Suits.Spades, "Ten of Spades"},
		    new object[] {11, Card.Suits.Spades, "Jack of Spades"},
		    new object[] {12, Card.Suits.Spades, "Queen of Spades"},
		    new object[] {13, Card.Suits.Spades, "King of Spades"}
		};
	}
}
