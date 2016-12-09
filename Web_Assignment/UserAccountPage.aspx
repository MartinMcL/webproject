<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAccountPage.aspx.cs" Inherits="Web_Assignment.UserAccountPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(document).on("click", "td", function (e) {
            var articleName = (e.target.innerHTML);
            if (articleName != "No upcoming events") {
                var params = { 'name': articleName };
                window.location.href = "ArticlePage?" + jQuery.param(params);
            }
        });
    </script>
    <div class="container">
        <div class="row">
            <div class="col-md-2 col-md-offset-1 col-xs-3 col-xs-offset-0 mainContent" id="profilePic">
                <img src="Images/avatar.png" class="img-responsive img-thumbnail" />

                <h3 id="userName"></h3>
                <div>
                    <ul>
                        <li><a runat="server" href="~/Account/Manage" title="Manage your account">Manage your account</a></li>
                    </ul>
                </div>
            </div>

            <div class="col-md-9 col-xs-9">
                <div class="mainContent container-fluid">
                    <div class="row">
                        <h3 class="col-md-offset-1 col-xs-offset-1 text-primary">Latest results</h3>
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                            <asp:Label runat="server" CssClass="text-success col-md-offset-1 col-xs-offset-1" ID="noResultsError">No results available for this sport.</asp:Label>
                            <asp:Table runat="server" ID="tblLatestResults" CssClass="table-bordered table-hover table">
                                <asp:TableHeaderRow>
                                    <asp:TableHeaderCell>Tournament</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Team #1</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Team #1 Score</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Team #2</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Team #2 Score</asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tbl1Tourn1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl1Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl1Team1Score">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl1Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl1Team2Score">No Information</asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tbl2Tourn2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl2Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl2Team1Score">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl2Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl2Team2Score">No Information</asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tbl3Tourn3">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl3Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl3Team1Score">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl3Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl3Team2Score">No Information</asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tbl4Tourn4">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl4Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl4Team1Score">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl4Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tbl4Team2Score">No Information</asp:TableCell>
                                </asp:TableRow>

                            </asp:Table>
                        </div>
                    </div>
                </div>

                <div class="mainContent container-fluid">
                    <div class="row">
                        <h3 class="col-md-offset-1 col-xs-offset-1 text-primary">Upcoming matches</h3>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:Label runat="server" CssClass="text-success col-md-offset-1 col-xs-offset-1" ID="noUpcoming">No upcoming matches available for this sport.</asp:Label>
                            <asp:Table runat="server" ID="upcomingMatches" CssClass="table-bordered table-responsive table-hover table">
                                <asp:TableHeaderRow>
                                    <asp:TableHeaderCell>Tournament</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Team #1</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Team #2</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>DateOfEvemt</asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tb1Tourn1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb1Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb1Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb1Date">No Information</asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tb2Tourn2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb2Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb2Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb2Date">No Information</asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tb3Tourn3">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb3Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb3Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb3Date">No Information</asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ID="tb4Tourn4">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb4Team1">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb4Team2">No Information</asp:TableCell>
                                    <asp:TableCell ID="tb4Date">No Information</asp:TableCell>
                                </asp:TableRow>

                            </asp:Table>
                        </div>
                    </div>
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
