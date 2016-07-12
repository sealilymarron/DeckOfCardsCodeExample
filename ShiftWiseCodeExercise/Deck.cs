using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ShiftWiseCodeExercise.Models
{
    public class Deck : IEnumerable<Card>
    {
	    private readonly ArrayList _cards;

	    public Deck()
	    {
		    _cards = new ArrayList();
	    }

	    public void Add(Card card)
	    {
		    _cards.Add(card);
	    }

	    public void SortAscending()
	    {
		    _cards.Sort();
	    }

	    public ArrayList Cards
	    {
		    get { return _cards; }
	    }

	    public int IndexOf(Card cardToFind)
	    {
		    return _cards.IndexOf(cardToFind);
	    }

	    IEnumerator<Card> IEnumerable<Card>.GetEnumerator()
	    {
		    foreach (Card card in _cards)
		    {
			    yield return card;
		    }
	    }

	    public IEnumerator GetEnumerator()
	    {
		    return _cards.GetEnumerator();
	    }

	    //https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
	    public void Shuffle()
	    {
		    var n = _cards.Count;
		    Random rand = new Random((int)DateTime.Now.Ticks);
		    for (int i = 0; i < n - 2; i++)
		    {
			    var j = rand.Next(i, n);
			    var swap = _cards[i];
			    _cards[i] = _cards[j];
			    _cards[j] = swap;
		    }
	    }
    }
}