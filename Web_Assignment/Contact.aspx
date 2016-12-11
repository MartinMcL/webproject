<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web_Assignment.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!-- Changed by Martin McLaughlin (S00151834) -->
    <div class="mainContent col-md-8 col-md-offset-2">
    <h2 class="text-primary"><%: Title %></h2>
    <h3>Contact us!</h3>
        <br />
        <br />
    <address class="text-muted">
        I.T. Sligo<br />
        5 Ash Lane, Ballinode, Sligo<br />
        <abbr title="Phone">P:</abbr>
        086.111.1111
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@esportshd.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@esportshd.com</a>
    </address>
    </div>
</asp:Content>
