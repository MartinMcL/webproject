<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Assignment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- gets the event name, uses query string to pass name to article page -->
    <script>
    $(document).on("click", "td", function (e) {
        var articleName = (e.target.innerHTML);

        var params = { 'name': articleName };
        window.location.href = "ArticlePage?" + jQuery.param(params);
    });
</script>


<div class="container row mainContent">
<div id="myCarousel" class="carousel slide col-md-9 mainContent" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
    <li data-target="#myCarousel" data-slide-to="3"></li>
  </ol>
  <!-- Wrapper for slides -->
  <div class="carousel-inner" style="height:360px;" role="listbox" >
    <div class="item active">
      <img src="http://e-sports.net/wp-content/uploads/2015/08/esports-betting.jpg" ">
    </div>

    <div class="item">
      <img src="https://s.aolcdn.com/hss/storage/midas/950f82ebebbd57f0e9586d9cd4108b00/202368928/esl.jpg" >
    </div>

    <div class="item">
      <img src="http://image3.redbull.com/rbcom/010/2015-12-02/1331763041375_1/0010/1/1500/1000/1/does-esports-need-a-players%E2%80%99-union.jpg" >
    </div>

    <div class="item">
      <img src="https://cdn1.twinfinite.net/wp-content/uploads/2016/05/esports.jpg" alt="Flower">
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
