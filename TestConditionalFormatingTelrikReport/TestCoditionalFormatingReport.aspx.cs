using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CoditionalFormating;

public partial class TestCoditionalFormatingReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Here create the object of our report class and assing it to the "ReportSource" property of "ReportViewer" control.
            ReportWithConditionalFomating pd = new ReportWithConditionalFomating();
            Telerik.Reporting.InstanceReportSource inst = new Telerik.Reporting.InstanceReportSource();
            inst.ReportDocument = pd;
            this.ReportViewer1.ReportSource = pd;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}