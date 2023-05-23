namespace ProEvents.API.Models;

public class Event
{
    public int Id { get; set; }
    public string Location { get; set; }
    public DateTime? EventDate { get; set; }
    public string Theme { get; set; }
    public int Capacity { get; set; }
    public string ImageURL { get; set; }
}
