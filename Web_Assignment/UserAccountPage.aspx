<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAccountPage.aspx.cs" Inherits="Web_Assignment.UserAccountPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container row">
        <div class="col-md-3 mainContent">
            <div id="profilePic">
                <img src="Images/avatar.png" class="img-responsive img-thumbnail" />
            </div>
            <h3 id="userName"></h3>
            <div>
                <ul>
                    <li><a runat="server" href="~/Account/Manage" title="Manage your account">Manage your account</a></li>
                </ul>
            </div>
        </div>

        <div class="col-md-9 ">
            <div class="mainContent">
                <h3 class="col-md-offset-1 text-primary">Latest results</h3>
                <h4>
                    <!-- your fav sport name here-->
                </h4>
                <div>
                    <!--last matches results here -->
                </div>
            </div>

            <div class="mainContent">
                <h3 class="col-md-offset-1 text-primary">Upcoming matches</h3>
                <h4>
                    <!-- your fav sport name here-->
                </h4>
                <div>
                    <!-- matches fixtures here -->
                </div>
            </div>
        </div>
    </div>

    <div class="container row">
        <h3>What to look out for</h3>
        <div class="col-md-4">
            <h6>Upcoming events for : <%: SportName(yourFavSport()) %></h6>
            <asp:Table runat="server" ID="tblUpcoming" CssClass="table table-hover">
                <asp:TableRow>
                    <asp:TableCell ID="upcoming1">No upcoming events</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>

        <div class="col-md-4">
            <h6>Upcoming events in <%: countryName(getLocation()) %></h6>
            <asp:Table runat="server" ID="Table1" CssClass="table table-hover">
                <asp:TableRow>
                    <asp:TableCell ID="nearby1">No upcoming events</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>

        <div class="col-md-4">
            <h6>Random upcoming event</h6>
            <asp:Table runat="server" ID="Table2" CssClass="table table-hover">
                <asp:TableRow>
                    <asp:TableCell ID="random1">No upcoming events</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </div>
</asp:Content>
