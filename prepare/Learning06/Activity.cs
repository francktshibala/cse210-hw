using System;
using System.Collections.Generic;

// Base class for all activities
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Virtual methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary can use the virtual methods, so it doesn't need to be overridden
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }

    protected int Minutes => _minutes;
}