public class Program
{
    public static void Main()
    {
        // Create a list to store activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 30), 30, 5.0),  // 5 km run
            new Cycling(new DateTime(2024, 10, 30), 45, 20.0), // 20 kph cycling
            new Swimming(new DateTime(2024, 10, 30), 40, 30)   // 30 laps
        };

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}