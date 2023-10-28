<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RemoteReportViewer.ascx.cs" Inherits="ASPNETMVC_SSRS_Demo.Views.Shared.RemoteReportViewer" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<form id="form1" runat="server">
    <div style="height: 720px; width: 100%">
        <asp:ScriptManager ID="scriptManager" runat="server" ScriptMode="Release" EnablePartialRendering="false" />
        <rsweb:ReportViewer Width="100%" Height="100%" ID="reportViewer" ShowPrintButton="true" KeepSessionAlive="true" runat="server" AsyncRendering="true" ProcessingMode="Remote">
        </rsweb:ReportViewer>

    </div>
</form>
