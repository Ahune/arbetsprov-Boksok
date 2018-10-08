<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Master1.Master"
    AutoEventWireup="true" CodeBehind="Bookstorage.aspx.cs" Inherits="Arbetsprov_BokSok.BookStorage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent"></asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
      
    
    
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
      <meta charset="UTF-8">
      <meta name="author" content="Álexander Mounzer">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <link rel="stylesheet" type="text/css" href="Style/StyleHomePage.css">
      <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
      <title>Qronos Biblotek</title>
    </head>
    <body>
        <div class ="headLiner">
            <h2>Books</h2>
        </div>      

        <div class="tableViewContainer">
            <table class="w3-table-all w3-hoverable">
                <thead>
                    <tr><th>Author</th><th>Title</th><th>Genre</th><th>Price</th><th>Publish date</th><th>Description</th></tr>
                </thead>
                <tbody id="books">
                </tbody>
            </table>
        </div>

        <div class="searchContainer">
            <label class="">Search by Title</label>
            <input id="titleTxt" class="w3-input w3-animate-input" style="width: 35%" placeholder="Enter your search here" type="text">
            <input id= "GetBookByTitle" type="button" value="Search" />                     
        </div> 

        <div class ="getRegisterContainer">
            <input id="getAllBtn" class="" type="button"  value="GetAllBooks" />
            <input id="cBtn" type="button" value="Clear"> 
        </div> 
        
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script type="text/javascript" src="/Script/jqueries.js"></script>
    </body>
</html>
</asp:Content>
