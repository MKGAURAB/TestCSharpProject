public class ReportDirector
{
    public Report PrepareReport(AReportBuilder reportBuilder)
    {
        reportBuilder.CreateReport();
        reportBuilder.SetName();
        reportBuilder.SetType();
        reportBuilder.SetContent();
        reportBuilder.SetFooter();
        reportBuilder.SetHeader();

        return reportBuilder.GetReport();
    }
}