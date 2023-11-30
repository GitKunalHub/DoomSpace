﻿<%@ Page Title="" Language="C#" MasterPageFile="~/EditProfile.master" AutoEventWireup="true" CodeFile="EditProfile.aspx.cs" Inherits="EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <form id="Form1" runat="server" >
      
    <div class="container-xl px-4 mt-4">
    <!-- Account page navigation-->
    <nav class="nav nav-borders">  
        <a class="nav-link active ms-0" href="#" target="__blank">Profile</a>
    </nav>
    <hr class="mt-0 mb-4">
    <div class="row">
        <div class="col-xl-4">
            <!-- Profile picture card-->
            <div class="card mb-4 mb-xl-0">
                <div class="card-header">Profile Picture</div>
                <div class="card-body text-center">
                    <!-- Profile picture image-->
                    <asp:Image ID="Image1" runat="server" class="img-account-profile rounded-circle mb-2" ImageUrl="images/IMCC.jpg" AlternateText="Not Uploaded Yet" />
                   <%-- <img class="img-account-profile rounded-circle mb-2" src='<%#Eval("Profile_Img")%>' alt="Not Uploaded Yet">--%>
                    <!-- Profile picture help block-->
                    <div class="small font-italic text-muted mb-4">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <br />JPG or PNG no larger than 5 MB</div>
                    <!-- Profile picture upload button-->
                    <asp:Button ID="btnUpload"  class="btn btn-primary" runat="server" Text="Upload New Image" />
                <%--    <button ID="btnUpload" class="btn btn-primary" type="button" runat="server" >Upload new image</button>--%>
                </div>
            </div>
        </div>
        <div class="col-xl-8">
            <!-- Account details card-->
            <div class="card mb-4">
                <div class="card-header">Account Details</div>
                <div class="card-body">
                    <form>
                        <!-- Form Group (username)-->
                       
                        <!-- Form Row-->
                        
                        <div class="row gx-3 mb-3">
                            <!-- Form Group (first name)-->
                            <div class="col-md-6">
                                <label class="small mb-1" for="inputFirstName">First name</label>
                                 <asp:TextBox ID="fn" class="form-control" runat="server"  placeholder="Enter your First name" value='<%#Eval("First_Name")%>'></asp:TextBox>
                               <%-- <input class="form-control" id="FirstName" runat="server"  type="text" placeholder="Enter your first name" value='<%#Eval("First_Name")%>' />--%>
                            </div>
                            <!-- Form Group (last name)-->
                            <div class="col-md-6">
                                <label class="small mb-1" for="inputLastName">Last name</label>
                                <asp:TextBox ID="ln" class="form-control" runat="server"  placeholder="Enter your last name" value='<%#Eval("Last_Name")%>'></asp:TextBox>
                              <%--  <input class="form-control" id="LastName" runat="server"  type="text" placeholder="Enter your last name" value='<%#Eval("Last_Name")%>' />--%>
                            </div>
                        </div>
                        <!-- Form Row        -->
                        
                        <!-- Form Row-->
                        <div class="row gx-3 mb-3">
                            <!-- Form Group (phone number)-->
                            <div class="col-md-6">
                                <label class="small mb-1" for="inputPhone">Phone number</label>
                                 <asp:TextBox ID="Contact" class="form-control" runat="server"  placeholder="Enter your Phone number"></asp:TextBox>
                              <%--  <input class="form-control" id="inputPhone" type="tel" runat="server"  placeholder="Enter your phone number" value='<%#Eval("Contact")%>' />--%>
                            </div>
                            <!-- Form Group (birthday)-->
                            <div class="col-md-6">
                                <label class="small mb-1" for="inputBirthday">Birthday</label>
                                 <asp:TextBox ID="bd" class="form-control" runat="server"  placeholder="Enter your birth date" TextMode="Date"></asp:TextBox>
                                <%--<input class="form-control" id="inputBirthday" type="text" runat="server"  name="birthday" placeholder="Enter your birthday" value='<%#Eval("DOB")%>' />--%>
                            </div>
                        </div>
                        <!-- Save changes button-->
                         <asp:Button ID="btnSave" runat="server" Text="Save Changes" />
                        
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
        </form>
</asp:Content>

