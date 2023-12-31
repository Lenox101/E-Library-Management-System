<%@ Page Title="" Language="C#" MasterPageFile="~/E-Library.Master" AutoEventWireup="true" CodeBehind="admin_user_management.aspx.cs" Inherits="E_Library_Management.adminProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
    <div class="row">
        
        <!------column1----->
        <div class="col-md-6">
             <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Member Details</h4>
                        </center>
                     </div>
                  </div>
                 
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-3">
                        <label>Registration N.O</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="txtregno" runat="server" placeholder="Reg N.0"></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>User Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtusername" runat="server" placeholder="User Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Account Status</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="txtaccountstatus" runat="server" placeholder="Account Status" ReadOnly="True"></asp:TextBox>
                              <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"><i class="far fa-pause-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-danger mr-1" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"><i class="fas fa-times-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-3">
                        <label>Date Of Birth</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtdob" runat="server" placeholder="DOB" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Contact No</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtcontact" runat="server" placeholder="Contact No" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Email Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtemailaddress" runat="server" placeholder="Email Address" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     
                     <div class="col-md-6">
                        <label>Year Of Study</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtyos" runat="server" placeholder="YOS" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                    
                      <div class="col-md-6">
                           <label>Full Postal Address</label>
                           <div class="form-group">
                              <asp:TextBox CssClass="form-control" ID="txtfulladdress" runat="server" placeholder="Full Postal Address" TextMode="MultiLine" Rows="2" ReadOnly="True"></asp:TextBox>
                           </div>
                        </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-8 mx-auto">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete User Permanently" OnClick="Button2_Click" />
                     </div>
                  </div>
               </div>
            </div>
          
            <br>
         </div>
         

      </div>

                <div class="col-md-6">
            
               
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Member List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [user_signup_tbl]"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="username" DataSourceID="SqlDataSource2">
                            <Columns>
                                <asp:BoundField DataField="reg_no" HeaderText="ID" ReadOnly="True" SortExpression="reg_no" InsertVisible="False" />
                                <asp:BoundField DataField="username" HeaderText="Username" ReadOnly="True" SortExpression="username" />
                                <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" />
                                <asp:BoundField DataField="account_status" HeaderText="Status" SortExpression="account_status" />
                                <asp:BoundField DataField="contact" HeaderText="Contact" SortExpression="contact" />
                                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                <asp:BoundField DataField="yos" HeaderText="YOS" SortExpression="yos" />
                            </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               
            
         </div>


        
   </div>
</asp:Content>
