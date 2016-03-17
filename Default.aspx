<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="height: 846px; width: 282px">
        <br />
    <h3>Search By Image.</h3>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" Width="292px" />
        <br />
        <asp:Button ID="Up" runat="server" OnClick="Up_Click" Text="Search " Width="135px" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="#CC0000"></asp:Label>
&nbsp; &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;
        <br />
            <h3>Search By Name.</h3>
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                              <br />                              <br />

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="142px" />
                <asp:Button ID="Pay" runat="server" OnClick="Pay_Click" Text="Pay" Width="135px" />
                <br />

                           <br />
     
        <asp:GridView ID="GridView1" runat="server" BackColor="#FF6699" AutoGenerateColumns="False"
             BorderColor="#CCCCCC" BorderStyle="Double" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />

            <Columns>

                <asp:TemplateField HeaderText="Uname">
                    <ItemTemplate>
                        <asp:Label ID="lbl" runat="server" Text='<%#Eval("Uname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Umg">
                    <ItemTemplate>
                        <asp:Image ID="amg" runat="server" ImageUrl='<%#Eval("Umg") %>' Height="100" Width="100"></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="lbli" runat="server" text='<%#Eval("Price") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        &nbsp;
        &nbsp;
        <br />



    </div>
  
</asp:Content>

