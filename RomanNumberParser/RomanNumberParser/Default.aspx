<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RomanNumberParser._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Roman Number Parser</h1>
        <p class="lead">This web page accepts an input string of a number in Roman Numerals and generates its integr value</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Enter the Roman number</h2>
            <p>
                Enter a number in Roman Numerals.</p>
            <p>
                &nbsp;<asp:TextBox ID="txtRoman" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Calculate</h2>
            <p>
                Click the button to translate the Roman Numerals in to an integer</p>
            <p>
                &nbsp;<asp:Button ID="btnCalc" runat="server" OnClick="btnCalc_Click" Text="Calculate" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>As an Integer</h2>
            <p>
                The Roman number as an integer, if an invalid Roman number was entered &quot;Invalid Number&quot; will be displayed.</p>
            <p>
                &nbsp;<asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
            </p>
        </div>
    </div>

</asp:Content>
