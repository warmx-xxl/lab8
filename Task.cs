public class Task
{
    public int TaskID { get; set; }
    public string CarName { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string CarID { get; set; }

    public Task(int taskID, string carName, DateTime start, DateTime end, string carID)
    {
        TaskID = taskID;
        CarName = carName;
        Start = start;
        End = end;
        CarID = carID;
    }

    public double Payment()
    {
        TimeSpan duration = End - Start;
        return duration.TotalHours * 10; // Пример расчёта стоимости аренды
    }

    public void Cancel()
    {
        Console.WriteLine($"Task {TaskID} has been canceled.");
    }

    public override string ToString()
    {
        return $"Task {TaskID}: Car {CarName}, Start: {Start}, End: {End}";
    }
}
