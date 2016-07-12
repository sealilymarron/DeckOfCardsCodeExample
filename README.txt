Kayla Gould 7/11/2016 Coding Example for ShiftWise

This example is coded as a .NET 4.5.2 class library.

The unit tests were done using NUnit (3.4.1.0) and run in VS2015 using NUnit3 Test Adapter extension.

Notes:
* "Ascending alphabetical order: clubs (lowest), followed by diamonds, hearts, and spades (highest). This ranking is used in the game of bridge." from https://en.wikipedia.org/wiki/High_card_by_suit

Basic "Stories"
* Cards should display suit and number. In the case of A, J, Q, K, the "number" should be output as the corresponding name instead. e.g. "Nine of Hearts", "Queen of Spades", "Ace of Diamonds".
* 1.a. Card should be sortable/comparable - ascending. 
	Criteria: Ascending order should be A, 2-10, J, Q, K with "numerical" ties broken by alphabetial order by suit. I.e. Clubs < Diamonds < Hearts < Spades
* 1.b. Deck containing 52 random/semi-random cards should output sorted after sorting.
* 2. Ordered or semi-random cards should be output randomized.