<%@ Page Title="" Language="C#" MasterPageFile="~/adminmaster.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="E_Library_Management.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container">
    <div class="row">
        <div class="col-md-6 mx-auto">
            <div class="card">
                <div class="card-body">

                    <div class="row">
                        <div class="col">
                            <center>
                                <img src="imgs/adminuser.png" width="150px"/>
                                <h2>Admin Login</h2>
                            </center>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <center>
                                <hr></hr>
                            </center>
                        </div>
                    </div>
                    <label class="font-weight-bold">Enter Your Registration Number</label>
                     <div class="row">
                         <div class="col">
                             <div class="form-group">
                                 <asp:TextBox CssClass="form-control" placeholder="Reg N.O" ID="txtreg_no" runat="server"></asp:TextBox>
                             </div>
                             </div>
                      </div>

                    <label class="font-weight-bold">Enter Password</label>

                    <div class="row">
                        <div class="col">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" placeholder="Password" ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                     </div>
                    <div class="row">
                        <div class="col">
                            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-info btn-block" OnClick="Button1_Click" />
                        </div>
                    </div>
                    <br />
                  </div>
                </div>
        </div>
        </div>
</section>


</asp:Content>
