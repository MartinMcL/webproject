<%@ Page Title="Register"  Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="ArticlePage.aspx.cs" Inherits="Web_Assignment.ArticlePage" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container lightgrey mainContent">

        <div class="col-md-9 col-md-offset-1">
            <h3 runat="server" id="eventTitle" class="text-primary"></h3>
            <h4 runat="server" id="fullName"></h4>
            <br />
            <p runat="server" id="eventDes"></p>
            <br />
            <span><label>Game: </label> <asp:Label ID="gameName" runat="server" /></span>
            <br />
            <span><label>How long it will run for : </label> <asp:Label ID="startDate" runat="server" /></span>
            <br />
            <span><label>Where is it: </label> <asp:Label ID="location" runat="server" /></span>
            <br />
            <span><label>Prize Money: </label> <asp:Label ID="prize" runat="server" /></span>
        </div>
        
    </div>

</asp:Content>
