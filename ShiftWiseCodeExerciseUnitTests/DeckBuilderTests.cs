using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using ShiftWiseCodeExercise.Models;

namespace ShiftWiseCodeExerciseUnitTests
{
    [TestFixture]
    public class DeckBuilderTests
    {
	    [Test]
	    public void BuildingDeckReturnsADeck()
	    {
		    var deckBuilder = new DeckBuilder();
		    var deck = deckBuilder.Build();

		   Assert.AreEqual(typeof(Deck),deck.GetType());
		   Assert.That(deck.Cards != null);
	    }

	    [Test]
	    public void BuildingADeckWith52CardsPopulates()
	    {
		    var deckBuilder = new DeckBuilder();
		    deckBuilder.With52Cards();
		    var deck = deckBuilder.Build();

		   Assert.That(deck.Cards.Count == 52);
		   foreach (var suit in Enum.GetValues(typeof(Card.Suits)).Cast<Card.Suits>())
		   {
			  for (int num = 1; num < 14; num++)
			  {
				 Assert.That(deck.Any(p => p.Number == num && p.Suit == suit));
			  }
		   }
	    }
    }
}
