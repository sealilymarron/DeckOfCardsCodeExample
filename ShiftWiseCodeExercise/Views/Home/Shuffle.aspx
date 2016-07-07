<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" Inherits="System.Web.Mvc.ViewPage<ShiftWiseCodeExercise.Models.Deck>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Shuffled</h3>
    <div>
	    <% Html.RenderPartial("DeckControl", Model); %>
    </div>
</asp:Content>
