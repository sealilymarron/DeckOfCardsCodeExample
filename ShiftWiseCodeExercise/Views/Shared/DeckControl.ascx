<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ShiftWiseCodeExercise.Models.Deck>" %>

    <p>
        <% foreach (ShiftWiseCodeExercise.Models.Card card in Model.Cards)
	   { %>
		  <div class="<%= card.Suit %>"><%= card.ToString() %></div>
	   <% } %>
    </p>


