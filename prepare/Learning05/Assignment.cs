using System;

class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get a summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}