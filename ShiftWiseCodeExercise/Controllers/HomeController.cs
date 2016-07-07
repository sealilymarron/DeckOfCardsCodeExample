using System.Web.Mvc;
using ShiftWiseCodeExercise.Models;

namespace ShiftWiseCodeExercise.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
	       var deck = new DeckBuilder().With52Cards().Build();
            return View(deck);
        }

	   //
	   // GET: /Home/Shuffle/

	    public ActionResult Shuffle()
	    {
		    var deck = new DeckBuilder().With52Cards().Build();
		    deck.Shuffle();

		    return View(deck);
	    }

	    //
	    // GET: /Home/SortAsc/

	    public ActionResult SortAsc()
	    {
		   var deck = new DeckBuilder().With52Cards().Build();
		   deck.Shuffle();//shuffling just to be fair since it's already ordered
		   deck.SortAscending();

		   return View(deck);
	    }
    }
}
