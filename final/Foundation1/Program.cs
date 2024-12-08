class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("3 Scary Games #200", "Markiplier", 300);
        var video2 = new Video("Game Development Tips", "Lixian", 480);
        var video3 = new Video("Elden Ring Playthrough", "Nautical", 360);

        // Add comments to videos
        video1.CommentsList.Add(new Comments("random_guy", "first"));
        video1.CommentsList.Add(new Comments("peeps", "Second game was the scariest"));
        video1.CommentsList.Add(new Comments("epicgamerman", "Can't wait for the next one!"));

        video2.CommentsList.Add(new Comments("laurenH", "Super helpful thank you!"));
        video2.CommentsList.Add(new Comments("indiegamedevguy", "As someone just starting this helped!"));
        video2.CommentsList.Add(new Comments("superfan", "Awesome tips!"));

        video3.CommentsList.Add(new Comments("topplayerpro", "git gud"));
        video3.CommentsList.Add(new Comments("turkeyboy55", "Theres a secret item behind the waterfall"));
        video3.CommentsList.Add(new Comments("soulsfan101", "Glad you finally started playing!"));

        // Display videos and their comments
        var videos = new List<Video> { video1, video2, video3 };
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}