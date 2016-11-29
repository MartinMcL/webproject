<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAccountPage.aspx.cs" Inherits="Web_Assignment.UserAccountPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container row">
        <div class="col-md-3 mainContent">
            <div id="profilePic" class="row">
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
                <h3>Latest results</h3>
                <h4>
                  <%: GetFavSport() %>  
                </h4>
                <div class="col-md-3 table-responsive">
                    <h2>Trending</h2>
                    <asp:Table runat="server" ID="tblTrend" CssClass="table table-hover">
                        <asp:TableRow>
                            <asp:TableCell ID="trend1">No Information</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ID="trend2">No Information</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ID="trend3">No Information</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ID="trend4">No Information</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </div>

            <div class="mainContent">
                <h3>Upcoming matches</h3>
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
            <img src="#" class="img-thumbnail img-responsive" alt="event for fav sport" />
            <!-- upcoming event of your preferred sport-->
            <p>
            </p>
        </div>

        <div class="col-md-4">
            <img src="#" class="img-thumbnail img-responsive" alt="event near user" />
            <!-- upcoming event near user location-->
            <p>
                <!-- some info about that event-->
            </p>
        </div>

        <div class="col-md-4">
            <img src="#" class="img-thumbnail img-responsive" alt="random upcoming event " />
            <!-- upcoming random event-->
            <p>
                <!-- some info about that event-->
            </p>
        </div>
    </div>
</asp:Content>
