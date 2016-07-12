using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShiftWiseCodeExercise.Models
{
    public class Card : IComparable
    {
	   public enum Suits { Clubs, Diamonds, Hearts, Spades };

	   public readonly int Number;
	   public readonly Suits Suit;

	   public Card(int value, Suits incSuit)
	   {
		  Number = value;
		  Suit = incSuit;
	   }

	   public override string ToString()
	   {
		  return mapCardNumbertoStringName() + " of " + Suit;
	   }

	    public int CompareTo(object obj)
	    {
		    var otherCard = (Card) obj;
		    var comparison = Number.CompareTo(otherCard.Number);
		    if (comparison == 0)
		    {
			    return Suit.CompareTo(otherCard.Suit);
		    }
		    return comparison;
	    }

	    private string mapCardNumbertoStringName()
	   {
		  Dictionary<int, string> cardMap = new Dictionary<int, string>()
			 { {1, "Ace"},
				{2, "Two"},
				{3, "Three"},
				{4, "Four"},
				{5, "Five"},
				{6, "Six"},
				{7, "Seven"},
				{8,"Eight"},
				{9, "Nine"},
				{10, "Ten"},
				{11, "Jack"},
				{12, "Queen"},
				{13, "King"}

			 };
		  return cardMap[Number]; 

	   }
    }
}