public class PDFReport : AReportBuilder
{
    public override void SetContent()
    {
        Report.Content = "PDF Content Section";
    }

    public override void SetFooter()
    {
        Report.ReportFooter = "PDF Footer Section";
    }

    public override void SetHeader()
    {
        Report.ReportHeader = "PDF Header Section";
    }

    public override void SetName()
    {
        Report.Name = "I am PDF";
    }

    public override void SetType()
    {
        Report.Type = "PDF";
    }
}