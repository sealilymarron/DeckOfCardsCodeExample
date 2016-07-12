using System;
using System.Linq;

namespace ShiftWiseCodeExercise.Models
{
    public class DeckBuilder
    {
	    private Deck _deck;

	    public DeckBuilder()
	    {
		    _deck = new Deck();
	    }
	    public Deck Build()
	    {
		    return _deck;
	    }

	    public DeckBuilder With52Cards()
	    {
		    for (int num = 1; num < 14; num++)
		    {
			    foreach (var suit in Enum.GetValues(typeof(Card.Suits)).Cast<Card.Suits>())
			    {
				   _deck.Add(new Card(num,suit));
			    }
			    
		    }
		    return this;
	    }
    }
}