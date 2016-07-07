using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NUnit.Framework;
using ShiftWiseCodeExercise.Models;

namespace ShiftWiseCodeExerciseUnitTests
{
    [TestFixture]
    public class DeckTests
    {
	    [Test]
	    public void CardShouldBeSortableAscendingByNumber()
	    {
		   var lowerCard = new Card(5, Card.Suits.Clubs);
		   var higherCard = new Card(7, Card.Suits.Clubs);

		   var deck = new Deck();
		   deck.Add(higherCard);//added in reverse order to prevent already being sorted
		   deck.Add(lowerCard);

		   deck.SortAscending();

		  
		   Assert.Less(deck.IndexOf(lowerCard), deck.IndexOf(higherCard));
	    }

	    [Test]
	    public void CardsOfSameNumberShouldBeSortedBySuit()
	    {
		   var lowerCard = new Card(6, Card.Suits.Diamonds);
		   var higherCard = new Card(6, Card.Suits.Hearts);

		   var deck = new Deck();
		   deck.Add(higherCard);//added in reverse order to prevent already being sorted
		   deck.Add(lowerCard);

		   deck.SortAscending();


		   Assert.Less(deck.IndexOf(lowerCard), deck.IndexOf(higherCard));
	    }

	    [Test]
	    public void FullDeckOfRandomCardsShouldBeSortedAscending()
	    {
		    var deck = new DeckBuilder().With52Cards().Build();
		    deck.Shuffle();
		    deck.SortAscending();

		    int arrayIndex = 0;
		    var deckArray = deck.ToArray();

		    for (int num = 1; num < 14; num++)
		    {
			   foreach (var suit in Enum.GetValues(typeof(Card.Suits)).Cast<Card.Suits>())
			   {
				  var card = deckArray[arrayIndex];
				  Assert.That(card.Number == num && card.Suit == suit);
				  arrayIndex++;
			   }
		    }
	    }

	    [Test]
	    public void DeckShouldBeShuffled()
	    {
		   var deck = new DeckBuilder().With52Cards().Build();
		   deck.Shuffle();

		   //WARNING: Mathmatically there is no test for a shuffled deck because a 
		   //deck could theoretically end up shuffled into perfect order. This means 
		   //there is a 1/52! chance that this test will fail for no good reason. 
		   //However, for the sake of argument, I would say that a deck in order 
		   //is not "shuffled". If I encountered it in a game I'd certainly scrap it 
		   //and reshuffle.

		   int countOfOrdered = 0;
		   int arrayIndex = 0;
		   var deckArray = deck.ToArray();
		   
		   for (int num = 1; num < 14; num++)
		   {
			  foreach (var suit in Enum.GetValues(typeof(Card.Suits)).Cast<Card.Suits>())
			  {
				  var card = deckArray[arrayIndex];
				  countOfOrdered += (card.Number == num && card.Suit == suit)? 1 : 0 ;
				  arrayIndex++;
			  }
		   }
		   Assert.That(countOfOrdered != 52);
	    }
    }
}
