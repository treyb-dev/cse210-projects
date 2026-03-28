using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Basics", "John", 500);
        v1.AddComment(new Comment("Alice", "Nice video"));
        v1.AddComment(new Comment("Bob", "Helpful"));
        v1.AddComment(new Comment("Sam", "Clear explanation"));

        Video v2 = new Video("Python Guide", "Jane", 700);
        v2.AddComment(new Comment("Mike", "Loved it"));
        v2.AddComment(new Comment("Anna", "Very useful"));
        v2.AddComment(new Comment("Tom", "Great job"));

        Video v3 = new Video("Java Intro", "Mark", 600);
        v3.AddComment(new Comment("Chris", "Good start"));
        v3.AddComment(new Comment("Ella", "Easy to follow"));
        v3.AddComment(new Comment("Luke", "Thanks"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"{c.Name}: {c.Text}");
            }

            Console.WriteLine();
        }
    }
}