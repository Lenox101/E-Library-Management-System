﻿<%@ Page Title="" Language="C#" MasterPageFile="~/E-Library.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="E_Library_Management.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section>
            <img src="imgs/home-bg.jpg" class="img-fluid"/>
        </section>

    <section>
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <center>
                        <h2>Our Features</h2>
                            <p><b>Our 3 Primary Features</b></p>
                        </center>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-4">
                        <center>
                        <img width="150px" src="imgs/digital-inventory.png" />
                        <h4>Digital Book Inventory</h4>
                        </center>
                    </div>

                     <div class="col-md-4">
                         <center>
                             <img width="150px" src="imgs/search-online.png" />
                         <h4>Search Books</h4>
                         </center>
                     </div>

                     <div class="col-md-4">
                         <center>
                             <img width="150px" src="imgs/defaulters-list.png" />
                         <h4>Defaulter List</h4>
                         </center>
                     </div>
                </div>
            </div>
        </section>

    <section>
        <img src="imgs/in-homepage-banner.jpg"  class="img-fluid"/>
    </section>

    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h1>Our Process</h1>
                        <p><b>We offer 3 Processes</b></p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img src="imgs/sign-up.png" width="150px"/>
                        <h4>Sign Up</h4>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img src="imgs/search-online.png" width="150px"/>
                        <h4>Search Books</h4>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img src="imgs/library.png" width="150px"/>
                        <h4>Visit Up</h4>
                    </center>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
