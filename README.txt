Kayla Gould 7/6/2016 Coding Example for ShiftWise

This example is coded against MVC2 and .NET 4.0 because that's what my computer had on it. I wish I'd taken the time to download a newer version of MVC. MVC2 doesn't even let you use Razor and that's much easier to work with. 

The unit tests were done using NUnit (3.4.1.0) and run in VS2010 using ReSharper. 

Notes:
* "Ascending alphabetical order: clubs (lowest), followed by diamonds, hearts, and spades (highest). This ranking is used in the game of bridge." from https://en.wikipedia.org/wiki/High_card_by_suit

Basic "Stories"
* Cards should display suit and number. In the case of A, J, Q, K, the "number" should be output as the corresponding name instead. e.g. "Nine of Hearts", "Queen of Spades", "Ace of Diamonds".
* 1.a. Card should be sortable/comparable - ascending. 
	Criteria: Ascending order should be A, 2-10, J, Q, K with "numerical" ties broken by alphabetial order by suit. I.e. Clubs < Diamonds < Hearts < Spades
* 1.b. Deck containing 52 random/semi-random cards should output sorted after sorting.
* 2. Ordered or semi-random cards should be output randomized.