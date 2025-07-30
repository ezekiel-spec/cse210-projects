using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Intro to C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Carol", "I learned a lot."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("OOP Concepts", "Jane Smith", 420);
        video2.AddComment(new Comment("Dave", "Nice breakdown."));
        video2.AddComment(new Comment("Eve", "Please make more like this!"));
        video2.AddComment(new Comment("Frank", "Clean and simple."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("LINQ Basics", "Paul Brown", 380);
        video3.AddComment(new Comment("Grace", "Now I understand LINQ."));
        video3.AddComment(new Comment("Heidi", "Bookmarking this."));
        video3.AddComment(new Comment("Ivan", "So helpful!"));
        videos.Add(video3);

        // Display each video's details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // blank line between videos
        }

    }
}
