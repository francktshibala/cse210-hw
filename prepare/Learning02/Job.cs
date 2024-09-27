public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // behaviors to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}


    