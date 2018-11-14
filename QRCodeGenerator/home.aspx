<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="QRCodeGenerator.home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 358px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Width and Height (px) : <asp:TextBox ID="txtWidthHeight" runat="server"></asp:TextBox><br />
        Location to save file : <input id="folderSelector" class="auto-style1" name="folderSelector" title="folderSelector" type="file" /><br />
        <asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
    </div>
    </form>
</body>
</html>
