public class Report
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Content { get; set; }
    public string ReportHeader { get; set; }
    public string ReportFooter { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Type: {Type}, Content: {Content}";
    }
}