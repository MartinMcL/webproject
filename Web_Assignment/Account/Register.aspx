﻿<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web_Assignment.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <%--<h2><%: Title %>.</h2> --%>
    <div class="container lightgrey mainContent">
        <div class="row">
            <div class="col-md-6 col-md-offset-3 text-center">
                <h1>eSports <span class="glyphicon glyphicon-hd-video"></span></h1>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="form-horizontal">
                <h4 class="text-primary text-center">Create a new account</h4>
                <p class="text-danger text-center">
                    <asp:Literal runat="server" ID="ErrorMessage" />
                </p>
                <hr />
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-3 col-md-offset-2 control-label">Email</asp:Label>
                    <div class="col-md-7">
                        <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                            CssClass="text-danger" ErrorMessage="The email field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-3 col-md-offset-2 control-label">Password</asp:Label>
                    <div class="col-md-7">
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                            CssClass="text-danger" ErrorMessage="The password field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-3 col-md-offset-2 control-label">Confirm password</asp:Label>
                    <div class="col-md-7">
                        <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label CssClass="col-md-3 col-md-offset-2 control-label" runat="server">Pick your favourite game</asp:Label>
                    <div class="col-md-7">
                        <asp:DropDownList runat="server" ID="ddlSportName" AutoPostBack="true" CssClass="form-control">                         
                        </asp:DropDownList>

                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-5 col-md-2">
                        <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-success" />
                    </div>
                </div>
            </div>
        </div>
    </div>




</asp:Content>
