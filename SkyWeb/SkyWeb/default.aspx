<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="default.aspx.cs" Inherits="SkyWeb._default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1">
    <style>
        .menulabel
        {
            font-family: Arial;
            font-size: 19px;
            font-weight:bold;
            color:white;
            text-align:center;
            cursor:pointer;
            padding-top:.5em;
        }
        .section
        {
            font-family: Arial;
            font-size: 19px;
            font-weight:bold;
            color:black;
            /*text-align:center;*/
            cursor:pointer;
            background-size:auto;
        }
        /*.section-panel
        {
            float:left;
        }*/
    </style>
    <div  style="float: left; width: 150px; height: 100%; position: relative; top: 0px; left: 0px;">
        <br />
            <asp:Panel ID="Panel1" runat="server" Width="150px" Height="65px">
            </asp:Panel>
            
    </div>
    <div id="section-top" style="float:left; width:603px; background-image: url('Images/tbtop.png'); height: 45px;">

            </div>
    <div runat="server" id="Div1" class="section" style="float:left; width:603px; background-image: url('Images/tbmiddle.png'); height: auto;">
        <!--<asp:Panel ID="Panel2" runat="server"></asp:Panel>/-->
            </div>
</asp:Content>