<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="BTL_LTW_cinematic.client.cinematic.changePassword.changePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../changePassword/changePassword.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" />
</head>
<body>
    <a href="../homePage/homePage.aspx" class="home-button"><i class="fas fa-house-chimney"></i> Về trang chủ</a>

    <form id="changePasswordForm" runat="server">
        <div>
            <input type="password" class="pwOld" id="pwOld1" name="pwOld1" placeholder="Nhập mật khẩu cũ" />
            <br />
            <input type="password" class="pwNew1" id="pwNew1" name="pwNew1" placeholder="Nhập mật khẩu mới" />
            <br />
            <input type="password" class="pwNew2" id="pwNew2" name="pwNew2" placeholder="Nhập lại mật khẩu mới" />
            <br />
            <asp:Button ID="submit" CssClass="register" runat="server" Text="Đổi mật khẩu" onclick="submit_onclick"/>
            <asp:Label ID="lblMessage" runat="server" Visible="false" ForeColor="Red"></asp:Label>
        </div>
    </form>

    <script>
        var submitButton = document.getElementById('submit');
        
        submitButton.onclick = function (e) {
            var pwOld = document.getElementById('pwOld1').value;
            var pwNew1 = document.getElementById('pwNew1').value;
            var pwNew2 = document.getElementById('pwNew2').value;

            if (pwOld.trim() === "" || pwNew1.trim() === "" || pwNew2.trim() === "") {
                e.preventDefault();
                alert("Vui lòng nhập đầy đủ thông tin.");
            }
        };
    </script>
</body>
</html>