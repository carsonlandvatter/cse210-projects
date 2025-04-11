using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning How to Code", "Tyson Landvatter", 2);
        video1.AddComment(new Comment("This was very insightful.", "Kayli Obrien"));
        video1.AddComment(new Comment("I loved these new tips and tricks!", "Danell Sorensen"));
        video1.AddComment(new Comment("I can't wait to keep learning more!", "Darci Lee"));
        videos.Add(video1);

        Video video2 = new Video("C# Tutorial", "Braxton Wagstaff", 14);
        video2.AddComment(new Comment("This helped me learn the importance of Abstraction.", "Devon Peterson"));
        video2.AddComment(new Comment("Great tutorial!", "James Barton"));
        video2.AddComment(new Comment("Loved learning about encapsulation.", "Hailey Atwell"));
        video2.AddComment(new Comment("Wonderful video.", "Randy Charleston"));
        videos.Add(video2);

        Video video3 = new Video("Life as a Coder", "Brandy Romero", 10);
        video3.AddComment(new Comment("Wow. I can't wait to get my degree in Software Development!", "Shyla Ransom"));
        video3.AddComment(new Comment("I think it would be pretty difficult.", "Matthew Bennet"));
        video3.AddComment(new Comment("I'll get started coding right now!", "Merrilee Smith"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}