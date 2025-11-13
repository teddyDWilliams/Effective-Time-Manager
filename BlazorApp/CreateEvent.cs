public class CreateEvent
{
    //public string? Title { get; set; }
    //public bool IsDone { get; set; } = false;
    String title;
    int day;
    int month;
    int year;
    int startTime;
    int endTime;
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