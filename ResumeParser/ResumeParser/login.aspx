<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ResumeParser.login" %>

<script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
<script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
<link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />
<!DOCTYPE html>
<div class="ts-product-container">
     <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-6">
    <div class="ts-panel panel panel-info">
        <div class="panel-heading">
            <h3>Resume Parser</h3>
        </div>
        <div class="panel-primary">
            <div class="panel-body">
               
                <form id="form1" runat="server">
                    <div>
                        <label for="txtUsername">
                            Username</label>
                        <asp:textbox id="txtUserName" runat="server" cssclass="form-control" placeholder="Enter Username"
                            required />
                        <br />
                        <label for="txtPassword">
                            Password</label>
                        <asp:textbox id="txtPWD" runat="server" textmode="Password" cssclass="form-control"
                            placeholder="Enter Password" required />
                        <br/>                        
                        <asp:button id="btnSubmit" runat="server" text="Submit" onclick="btnSubmit_Click" class="btn btn-primary" />
                    </div>
                </form>
                    </div>
                    </div>
                <div class="col-md-3"></div>
            </div>
        </div>
    </div>
</div>


