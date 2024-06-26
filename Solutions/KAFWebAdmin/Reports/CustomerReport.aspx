﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerReport.aspx.cs" Inherits="CustomerReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formCustomerReport" runat="server">
        <div>
            <asp:Label ID="lblMessage" CssClass="danger" runat="server"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer  ID="CustomerListReportViewer" runat="server" Width="100%" EnableExternalImages="true"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
