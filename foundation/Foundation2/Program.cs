using System;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        Video video2 = new Video("Advanced C# Programming", "TechWorld", 1800);
        Video video3 = new Video("Mastering OOP in C#", "DevGuru", 1500);

        // Create comments for video1
        video1.AddComment(new Comment("John Doe", "Great video, very helpful!"));
        video1.AddComment(new Comment("Jane Smith", "I learned a lot from this."));
        video1.AddComment(new Comment("Mark Lee", "Well explained, thank you!"));

        // Create comments for video2
        video2.AddComment(new Comment("Alice", "This video is amazing!"));
        video2.AddComment(new Comment("Bob", "I was looking for something like this."));
        video2.AddComment(new Comment("Charlie", "Superb tutorial, loved it!"));

        // Create comments for video3
        video3.AddComment(new Comment("Eve", "I finally understand OOP."));
        video3.AddComment(new Comment("Frank", "Thanks for making this topic clear."));
        video3.AddComment(new Comment("Grace", "Great teaching style."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}