<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web_insurance.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="layui/css/layui.css" rel="stylesheet" />
    <link href="Register.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="mb layui-card">
            <div class="layadmin-user-login-main">
                <div class=" layadmin-user-login-box layadmin-user-login-header">
                    <h2>保险公司个人管理系统</h2>
                </div>

                <div class="layadmin-user-login-box layadmin-user-login-body layui-form">
                    <div class="layui-form-item">
                        <label class="layadmin-user-login-icon layui-icon layui-icon-username" for="LAY-user-login-username"></label>
                        <asp:TextBox ID="username" type="text" name="username" lay-verify="required" placeholder="姓名" CssClass="layui-input" runat="server" OnTextChanged="username_TextChanged"></asp:TextBox>
                    </div>
                    <div class="layui-form-item">
                        <label class="layadmin-user-login-icon layui-icon layui-icon-password" for="LAY-user-login-password"></label>
                        <asp:TextBox ID="password" type="password" name="password" lay-verify="required" placeholder="输入密码" CssClass="layui-input" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
                    </div>
                    <div class="layui-form-item">
                        <label class="layadmin-user-login-icon layui-icon layui-icon-password" for="LAY-user-login-password"></label>
                        <asp:TextBox ID="passwords" type="password" name="passwords" lay-verify="required" placeholder="再次输入密码" CssClass="layui-input" runat="server" OnTextChanged="passwords_TextChanged"></asp:TextBox>
                    </div>
                    <div class="layui-form-item">
                        <label class="layadmin-user-login-icon layui-icon layui-icon-username" for="LAY-user-login-username"></label>
                        <asp:TextBox ID="number" type="text" name="number" lay-verify="required" placeholder="工号" CssClass="layui-input" runat="server" OnTextChanged="number_TextChanged"></asp:TextBox>
                    </div>
                    <asp:Button ID="submit" CssClass="layui-btn layui-btn-fluid" runat="server" Text="注 册" OnClick="submit_Click" />
                    <div class="layui-form-item" style="margin-bottom: 20px; margin-top: 10px;">
                        <a href="Login.aspx" class="layadmin-user-jump-change layadmin-link" style="color: black">已有账号，马上登录</a>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="layui/layui.js"></script>
</body>
</html>
