<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Blood_Donor_Portal.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Blood Donor Portal</title>
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="Home.css"/>
</head>
<body>
     <section class="home" id="home">

        <header class="header" id="header">
            <div class="logo">
                <a href="home.html" class="img"><img src="Img/logo.svg" alt="logo"></a>
                <a href="home.html">BDP</a>
            </div>
            <div class="nav">
                <nav><a href="#home">Home</a></nav>
                <nav><a href="#search">Search Donor</a></nav>
                <nav><a href="#donor">Be a Donor</a></nav>
                <nav><a href="#sign_out" class="signout">Sign Out</a></nav>
            </div>
        </header>
         <div class="Homebox">
        <div class="content">
            <h2>Welcome Baskar</h2>
            <p>Every Blood donor is a life saver so donate blood and save lives, every drop counts, become a donor today.</p>
            <div class="homebtn">
                <a href="#donor" class="donor">Donate Now</a>
                <a href="#search" class="search">Need a Donor</a>
            </div>
        </div>
             <div class="img-container">
                 <img src="Img/Homebg.svg" />
             </div>
         </div>
    </section>
    <section id="search" style="min-height: 100vh;"></section>
    <section id="donor" style="min-height: 100vh;"></section>


<script src="Home.js"></script>
</body>
</html>
