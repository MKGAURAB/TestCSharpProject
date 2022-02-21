public abstract class AReportBuilder
{
    protected Report Report;
    public void CreateReport()
    {
        Report = new Report();
    }
    public Report GetReport()
    {
        return Report;
    }

    public abstract void SetName();
    public abstract void SetType();
    public abstract void SetContent();
    public abstract void SetHeader();
    public abstract void SetFooter();
}