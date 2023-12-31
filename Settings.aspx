<%@ Page Title="" Language="C#" MasterPageFile="~/E-Library.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="E_Library_Management.Settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <h1 class="my-4">Settings</h1>
        <div class="row">
            <div class="col-md-4">
                <h3>Profiles</h3>
                <table class="table border border-primary">
                    <tbody>
                        <tr>
                            <th scope="row">First Name</th>
                            <td>John</td>
                        </tr>
                        <tr>
                            <th scope="row">Last Name</th>
                            <td>Doe</td>
                        </tr>
                        <tr>
                            <th scope="row">Date of Birth</th>
                            <td>12/31/1999</td>
                        </tr>
                        <tr>
                            <th scope="row">Contact Number</th>
                            <td>+1 123 456 7890</td>
                        </tr>
                        <tr>
                            <th scope="row">Email Address</th>
                            <td>john.doe@example.com</td>
                        </tr>
                        <tr>
                            <th scope="row">Postal Address</th>
                            <td>10984</td>
                        </tr>
                        <tr>
                            <th scope="row">Gender</th>
                            <td>Male</td>
                        </tr>
                        <tr>
                            <th scope="row">Year of Study</th>
                            <td>2023</td>
                        </tr>
                        <tr>
                            <th scope="row">Registration Number</th>
                            <td>JD01</td>
                        </tr>
                    </tbody>
                </table>
              
                <br /><br />
            </div>
             
                        <div class="col-md-8 mx-auto">
             <div class="card">
                 <div class="card-body">

                     <div class="row">
                         <div class="col">
                             <center>
                                 <img src="imgs/generaluser.png" width="100px"/>
                                 <h4>Change Profile Photo</h4>
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
                                     <asp:TextBox CssClass="form-control" placeholder="Enter First Name" ID="TextBox3" runat="server"></asp:TextBox>
                                  </div>
                            </div>
                            
                            <div class="col-md-4">
                                  <div class="form-group">
                                      <asp:Label ID="Label8" runat="server" Text="Second Name"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter Second Name" ID="TextBox10" runat="server"></asp:TextBox>
                                  </div>
                            </div>

                            <div class="col-md-4">
                                 <div class="form-group">
                                     <asp:Label ID="Label2" runat="server" Text="Date of Birth"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Date Of Birth" ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
                                 </div>           
                            </div>

                            <div class="col-md-6">
                                   <div class="form-group">
                                       <asp:Label ID="Label3" runat="server" Text="Contact Number"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Contact Number" ID="TextBox5" runat="server"></asp:TextBox>
                                   </div>  
                            </div>
                            
                            <div class="col-md-6">
                                   <div class="form-group">
                                       <asp:Label ID="Label4" runat="server" Text="Email Address"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter Email" ID="TextBox6" runat="server" TextMode="Email"></asp:TextBox>
                                   </div>  
                            </div>
                            <div class="col-md-4">
                                   <div class="form-group">
                                       <asp:Label ID="Label5" runat="server" Text="Year of Study"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter YOS" ID="TextBox7" runat="server"></asp:TextBox>
                                   </div>  
                            </div>
                            <div class="col-md-4">
                                   <div class="form-group">
                                       <asp:Label ID="Label6" runat="server" Text="Registration Number"></asp:Label>
                                     <asp:TextBox CssClass="form-control" placeholder="Enter Reg No" ID="TextBox8" runat="server"></asp:TextBox>
                                   </div>  
                            </div>
                         <div class="col-md-4">
                               <div class="form-group">
                                   <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
                                   <asp:DropDownList CssClass="form-control" placeholder="Gender" ID="DropDownList1" runat="server">
                                       <asp:ListItem>Male</asp:ListItem>
                                       <asp:ListItem>Female</asp:ListItem>
                                   </asp:DropDownList>
                               </div>  
                        </div>

                         <div class="col">
                             <div class="form-group">
                                 <label class="font-weight-bold">Postal Address</label>
                                 <asp:TextBox ID="TextBox9" CssClass="form-control" placeholder="Enter Postal Address" runat="server"></asp:TextBox>
                             </div>
                         </div>

                      </div>
                     <label class="font-weight-bold">Enter New Username</label>
                      <div class="row">
                          <div class="col">
                              <div class="form-group">
                                  <asp:TextBox CssClass="form-control" placeholder="Enter Username" ID="TextBox1" runat="server"></asp:TextBox>
                              </div>
                              </div>
                       </div>
                     <label class="font-weight-bold">Enter Old Password</label>
                     <div class="row">
                        <div class="col">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" placeholder="Confirm Password" ID="TextBox12" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                     </div>

                     <label class="font-weight-bold">Enter New Password</label>

                     <div class="row">
                         <div class="col">
                             <div class="form-group">
                                 <asp:TextBox CssClass="form-control" placeholder="Password" ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                             </div>
                         </div>
                      </div>
                     
                      <label class="font-weight-bold">Confirm New Password</label>

                     <div class="row">
                         <div class="col">
                             <div class="form-group">
                                 <asp:TextBox CssClass="form-control" placeholder="Confirm Password" ID="TextBox11" runat="server" TextMode="Password"></asp:TextBox>
                             </div>
                         </div>
                      </div>

                     <br />

                    <!-----------To DataBase--------------->
                     <div class="row">
                         <div class="col">
                             <asp:Button ID="Button1" runat="server" Text="Update Info" class="btn btn-primary btn-lg"/>
                         </div>
                     </div>
                     

                   </div>
                 </div>


         </div>

        </div>


    </div>
</asp:Content>
