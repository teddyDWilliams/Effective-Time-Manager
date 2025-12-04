public class CreateEvent
{
    //public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
    public String title { get; set; }
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }
    public int startHour { get; set; }
    public int startMinute { get; set; }
    public int endHour { get; set; }
    public int endMinute { get; set; }
    public String m
    {
        get
        {
            
            switch(month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6: 
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12: 
                    return "December";
                default:
                    return "Unknown";
            }
        }  
    }
    public DateTime startDate;
    public DateTime endDate;
    public TimeSpan eventDuration;
    public TimeSpan timeUntil;
    public CreateEvent(String title,int day,int month,int year,int startHour,int startMinute,int endHour,int endMinute)
    {
        this.title = title;
        this.day = day;
        this.month = month;
        this.year = year;
        this.startHour = startHour;
        this.startMinute = startMinute;
        this.endMinute = endMinute;

        startDate = new DateTime(year,month,day,startHour,startMinute,0);
        endDate = new DateTime(year,month,day,endHour,endMinute,0);
        eventDuration = endDate.Subtract(startDate);
        timeUntil = startDate.Subtract(DateTime.Now);
    }
}