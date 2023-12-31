<%@ Page Title="" Language="C#" MasterPageFile="~/signupmaster.Master" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Debug="true" Inherits="E_Library_Management.Sign_Up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="container-fluid">
     <div class="row">
         <div class="col-md-8 mx-auto">
             <div class="card">
                 <div class="card-body">

                     <div class="row">
                         <div class="col">
                             <center>
                                 <img src="imgs/generaluser.png" width="100px"/>
                                 <h4>Sign Up Become A Member</h4>
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

                     <div class="row">
                            <div class="col-md-4">
                                  <div class="form-group">
                                      <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter First Name" ID="txtfirst_name" runat="server"></asp:TextBox>
                                  </div>
                            </div>
                            
                            <div class="col-md-4">
                                  <div class="form-group">
                                      <asp:Label ID="Label8" runat="server" Text="Second Name"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter Second Name" ID="txtsecond_name" runat="server"></asp:TextBox>
                                  </div>
                            </div>

                            <div class="col-md-4">
                                 <div class="form-group">
                                     <asp:Label ID="Label2" runat="server" Text="Date of Birth"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Date Of Birth" ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
                                 </div>           
                            </div>

                            <div class="col-md-6">
                                   <div class="form-group">
                                       <asp:Label ID="Label3" runat="server" Text="Contact Number"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Contact Number" ID="txtcontact" runat="server"></asp:TextBox>
                                   </div>  
                            </div>
                            
                            <div class="col-md-6">
                                   <div class="form-group">
                                       <asp:Label ID="Label4" runat="server" Text="Email Address"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter Email" ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
                                   </div>  
                            </div>
                            <div class="col-md-4">
                                   <div class="form-group">
                                       <asp:Label ID="Label5" runat="server" Text="Year of Study"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter YOS" ID="txtyos" runat="server"></asp:TextBox>
                                   </div>  
                            </div>
                            
                         <div class="col-md-4">
                               <div class="form-group">
                                   <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
                                   <asp:DropDownList CssClass="form-control" placeholder="Gender" ID="txtgender" runat="server">
                                       <asp:ListItem>Male</asp:ListItem>
                                       <asp:ListItem>Female</asp:ListItem>
                                   </asp:DropDownList>
                               </div>  
                        </div>

                         <div class="col">
                             <div class="form-group">
                                 <label class="font-weight-bold">Postal Address</label>
                                 <asp:TextBox ID="txtpostal_address" CssClass="form-control" placeholder="Enter Postal Address" runat="server"></asp:TextBox>
                             </div>
                         </div>

                      </div>
                     <label class="font-weight-bold">Enter Your Username</label>
                      <div class="row">
                          <div class="col">
                              <div class="form-group">
                                  <asp:TextBox CssClass="form-control" placeholder="Enter Username" ID="txtusername" runat="server"></asp:TextBox>
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
                     
                      <label class="font-weight-bold">Confirm Password</label>

                     <div class="row">
                         <div class="col">
                             <div class="form-group">
                                 <asp:TextBox CssClass="form-control" placeholder="Confirm Password" ID="txtconfirm_password" runat="server" TextMode="Password"></asp:TextBox>
                             </div>
                         </div>
                      </div>

                     <br />

                    <!-----------To DataBase--------------->
                     <div class="row">
                         <div class="col">
                             <asp:Button ID="Button1" runat="server" Text="Sign Up" class="btn btn-primary btn-block" OnClick="Button1_Click1"/>
                         </div>
                     </div>
                     

                   </div>
                 </div>


         </div>
         </div>
 </section>

</asp:Content>
