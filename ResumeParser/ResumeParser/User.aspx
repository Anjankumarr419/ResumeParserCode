<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" MasterPageFile="~/ResumeParser.Master" Inherits="ResumeParser.User" %>





<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <table style="border: solid 15px blue; width: 100%; vertical-align: central;">
                <tr>
                    <td style="padding-left: 20px; padding-top: 50px; padding-bottom: 50px; background-color: skyblue;">Enter Name To Search #:
                        <asp:TextBox ID="searchBox" runat="server" />
                        <asp:Button ID="Button1" Text="Search" runat="server" OnClick="btnSearch_Click" /></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" Width="100%"
                            OnRowDataBound="GridViewStudent_OnRowDataBound"
                            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                <asp:BoundField DataField="Skills" HeaderText="Skills" />
                                <asp:BoundField DataField="Summary" HeaderText="Summary" />
                                <asp:BoundField DataField="Experience" HeaderText="Experience" />
                                <asp:BoundField DataField="Education" HeaderText="Education" />
                                <asp:BoundField DataField="Interests" HeaderText="Interests" />
                                <asp:BoundField DataField="Languages" HeaderText="Languages" />
                            </Columns>
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SortedAscendingCellStyle BackColor="#EDF6F6" />
                            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                            <SortedDescendingCellStyle BackColor="#D6DFDF" />
                            <SortedDescendingHeaderStyle BackColor="#002876" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </asp:Content>