// using System;
// using System.Collections.Generic;

// public abstract class Goal {
//     protected string _shortName;
//     protected string _description;
//     protected int _points;

//     public Goal(string name, string description, int points) {
//         _shortName = name;
//         _description = description;
//         _points = points;
//     }

//     public abstract void RecordEvent();  // Abstract method for recording an event
//     public abstract bool IsComplete();  // Abstract method for checking if goal is complete

//     public virtual string GetDetailsString() {
//         return $"{_shortName}: {_description}";
//     }

//     public virtual string GetStringRepresentation() {
//         return $"{_shortName} - {_description}";
//     }
// }

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Base Goal class
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public string GetName() => _shortName;
    public int GetPoints() => _points;
}