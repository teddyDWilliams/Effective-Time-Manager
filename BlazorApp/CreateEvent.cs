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
    public DateTime date;
    public CreateEvent(String title,int day,int month,int year,int startTime,int endTime)
    {
        this.title = title;
        this.day = day;
        this.month = month;
        this.year = year;
        this.startTime = startTime;
        this.endTime = endTime;
        
        date = new DateTime(year,month,day,0,0,0);
    }
}