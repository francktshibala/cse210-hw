// Video class to store video information and list of comments
class Video
{
    private string _title;
    private string _author;
    private int _length; // Length in seconds
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display the video details
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}