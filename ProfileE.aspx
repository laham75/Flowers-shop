<%@ Page Title="" Language="C#" MasterPageFile="~/MasterE.master" AutoEventWireup="true" CodeFile="ProfileE.aspx.cs" Inherits="ProfileE" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <p class="text-danger">
         &nbsp;</p>

    <div class="form-horizontal">
        <h2>My Profile.</h2>
        <hr />







             <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Username" CssClass="col-md-2 control-label">User Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
            </div>
        </div>

            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" CssClass="form-control" />
            </div>
        </div>


        <br />




        <div class="form-group">
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="Update" Text="Submit" CssClass="btn btn-default" />
                
            &nbsp;&nbsp;
                <asp:Button runat="server" OnClick="View" Text="To view your data" CssClass="btn btn-default" ID="Button1" />
                
            </div>
        </div>
    </div>
</asp:Content>

