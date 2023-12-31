<%@ Page Title="" Language="C#" MasterPageFile="~/userloginmaster.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="E_Library_Management.userlogin" %>
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
                                 <img src="imgs/generaluser.png" width="150px"/>
                                 <h2>Member Login</h2>
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
                     <label class="font-weight-bold">Enter Your Username</label>
                      <div class="row">
                          <div class="col">
                              <div class="form-group">
                                  <asp:TextBox CssClass="form-control" placeholder="Enter Your Username" ID="txtusername1" runat="server"></asp:TextBox>
                              </div>
                              </div>
                       </div>

                     <label class="font-weight-bold">Enter Password</label>

                     <div class="row">
                         <div class="col">
                             <div class="form-group">
                                 <asp:TextBox CssClass="form-control" placeholder="Password" ID="txtpassword1" runat="server" TextMode="Password"></asp:TextBox>
                             </div>
                         </div>
                      </div>
                     <div class="row">
                         <div class="col">
                             <asp:Button ID="Button2" runat="server" Text="Login" class="btn btn-info btn-block" OnClick="Button2_Click1" />
                         </div>
                     </div>
                     <br />
                     <p style="font-family: 'Bahnschrift SemiBold'; color: #3366FF">Don't have an Account?</p>
                     <div class="row">
                         <div class="col">
                             <asp:Button ID="Button1" PostBackUrl="Sign_Up.aspx" runat="server" Text="Sign Up" class="btn btn-primary btn-block"/>
                         </div>
                     </div>
                     

                   </div>
                 </div>


         </div>
         </div>
 </section>
</asp:Content>
