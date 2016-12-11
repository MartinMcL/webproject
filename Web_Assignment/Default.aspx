<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Assignment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script> //Jquery was done by Dylan Murray (s00156252)
        $(document).ready(function () {
            $('h6, td').click(function (e) {   //event for the table cells and carousel so they can be clicked
                var articleName = (e.target.innerHTML);
                if (articleName != "No Information") {
                    var params = { 'name': articleName };
                    window.location.href = "ArticlePage?" + jQuery.param(params);   //gets the event name, uses query string to pass name to article page
                }
            });
            $('h6, td').hover(function () {   //changes the cursor to look better when hovering over the table and carousel
                $(this).css('cursor', 'pointer');
            });
        });

    </script>

    <!-- Bootstrap was done by both project members -->
    <div class="container row mainContent">
        <div id="myCarousel" class="carousel slide col-md-offset-1 col-md-10 col-xs-10 col-xs-offset-1 mainContent" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>
            <!-- Wrapper for slides -->
            <div class="carousel-inner" style="max-height: 400px" role="listbox">
                <div class="item active col-xs-12">
                    <img class="imgCss" src="Images/es_1.jpg" />
                    <div class="carousel-caption">
                        <h6 id="eventTitle1" runat="server"></h6>
                        <p id="cap0" runat="server"></p>
                    </div>
                </div>

                <div class="item col-xs-12">
                    <img class="imgCss" src="Images/es_2.png" />
                    <div class="carousel-caption">
                        <h6 id="eventTitle2" runat="server"></h6>
                        <p id="cap1" runat="server"></p>
                    </div>
                </div>

                <div class="item col-xs-12">
                    <img class="imgCss" src="Images/es_3.jpg" />
                    <div class="carousel-caption">
                        <h6 id="eventTitle3" runat="server"></h6>
                        <p id="cap2" runat="server"></p>
                    </div>
                </div>

                <div class="item col-xs-12">
                    <img class="imgCss" src="Images/es_4.jpg" />
                    <div class="carousel-caption">
                        <h6 id="eventTitle4" runat="server"></h6>
                        <p id="cap3" runat="server"></p>
                    </div>
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

    </div>

    <div class="container row mainContent">
        <div class="col-md-6 table-responsive">
            <h2>Upcoming events</h2>
            <asp:Table runat="server" ID="tblUpcoming" CssClass="table table-hover">
                <asp:TableRow>
                    <asp:TableCell ID="upcoming1">No Information</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="upcoming2">No Information</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="upcoming3">No Information</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="upcoming4">No Information</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>

        <div class="col-md-6 table-responsive">
            <h2>Latest tournaments</h2>
            <asp:Table runat="server" ID="tblTourns" CssClass="table table-hover">
                <asp:TableRow>
                    <asp:TableCell ID="latest1">No Information</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="latest2">No Information</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="latest3">No Information</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ID="latest4">No Information</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>

    </div>
</asp:Content>
