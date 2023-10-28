<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadReport.aspx.cs" Inherits="DownloadReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="../DesignsAndScripts/Styles/bootstrap_min.css" rel="stylesheet" />
  <script type="text/javascript" src="../DesignsAndScripts/Scripts/plugins/jquery/jquery.js"></script>
    <!-- load jQuery 2.1.1 -->


    <script src="../DesignsAndScripts/Scripts/plugins/bootstrap/bootstrap.js"></script>
   
<script>

    function fnctdd()
    {

    }
    $(document).ready(function () {
        $('.btnReportClose').click(function (event) {
        try {
            event.preventDefault();

           

            window.parent.$(".reportmodal").modal("hide");

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    });
  
    
</script>
</head>
<body>
    <form id="formCustomerReport" runat="server">
        <div class="panel panel-primary list-panel" id="list-panel">
            <div class="panel-heading list-panel-heading" style="HEIGHT: 37PX;">

                <div class="col-lg-3" style="float: right; text-align: right;">
                    <button type="button"data-dismiss="modal" aria-label="Close" id="btnReportClose" class="close btnReportClose"
                        style="opacity: 1.0; opacity: 1.0; margin-top: -11px; color: white; margin-right: -20px; font-size: 39px;">
                        <span aria-hidden="true"  data-dismiss="modal" class=" btnReportClose">&times;</span>
                    </button>
                </div>
            </div>

            <div class="panel-body">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <rsweb:ReportViewer ID="CustomerListReportViewer" runat="server" Width="100%" EnableExternalImages="true"></rsweb:ReportViewer>
            </div>
        </div>
    </form>
</body>
</html>
