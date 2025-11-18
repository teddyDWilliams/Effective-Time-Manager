public class CreateEvent
{
    //public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
    public String title { get; set; }
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }
    public int startTime { get; set; }
    public int endTime { get; set; }
    public CreateEvent(String title,int day,int month,int year,int startTime,int endTime)
    {
        this.title = title;
        this.day = day;
        this.month = month;
        this.year = year;
        this.startTime = startTime;
        this.endTime = endTime;
    }
    
}