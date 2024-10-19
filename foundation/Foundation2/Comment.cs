using System;
using System.Collections.Generic;

// Comment class to store the name and text of a comment
class Comment
{
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Method to display the comment
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_commentText}");
    }
}