using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();


        Video video1 = new Video("Understanding Abstraction", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "I learned a lot."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));

        Video video2 = new Video("Classes in C#", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Eva", "Looking forward to more videos."));
        video2.AddComment(new Comment("Frank", "This was exactly what I needed."));

        Video video3 = new Video("Inheritance and Polymorphism", "Alice Johnson", 600);
        video3.AddComment(new Comment("Grace", "Excellent content."));
        video3.AddComment(new Comment("Hank", "Please do a follow-up video."));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
