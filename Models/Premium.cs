using BaltaTest.Models;

public class Premium
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int StudentId { get; set; }

    public Student? Student { get; set; }
}
