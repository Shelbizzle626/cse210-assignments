using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("First Title", "First Author", 300);
        video1.AddComment(new Comment("Billy", "Great Video!" ));
        video1.AddComment(new Comment("Bob", "Really helpful, thanks!" ));
        video1.AddComment(new Comment("Mckenna", "I can't believe that was possible. "));
        videos.Add(video1);

        Video video2 = new Video("Second Title", "Second Author", 457);
        video2.AddComment(new Comment("Tyler", "This was awesome!" ));
        video2.AddComment(new Comment("Layla", "I don't know how you can do that. "));
        video2.AddComment(new Comment("Kari", "Someday I'll do this. "));
        videos.Add(video2);

        Video video3 = new Video("Third Title", "Third Author", 245);
        video3.AddComment(new Comment("Aaron", "I wish I had those skills. "));
        video3.AddComment(new Comment("Carter", "That was so interesting." ));
        video3.AddComment(new Comment("Scott", "That's so funny. "));
        videos.Add(video3);


        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            video.DisplayAll();
            Console.WriteLine();
        }
    }
}