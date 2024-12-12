using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Funnny Hamsters", "Jake paulton", 500);
        video1.AddComment("Mickey143", "Cool video, but not my favorite");

        video1.AddComment("Mark45234", "First");

        video1.AddComment("_XXX_GILLDEN_XXX_", "Why doesn't this havve more views????");

        videos.Add(video1);


        Video video2 = new Video("Egg hatch complation", "Thatguy68", 350);
        video2.AddComment("Hammyfriend8", "Cool video");

        video2.AddComment("Hunkerut45", "lol");

        videos.Add(video2);


        Video video3 = new Video("Minecraft in real life: 3", "Lifecraft34", 1340);
        video3.AddComment("FunnyLion", "Cool video, def my favorite! :)");

        video3.AddComment("Mark", "2 videos in 1 week!!!!");
        
        video3.AddComment("ratsquire", "Why was this recommeded to me?");
              
        video3.AddComment("Markiplier", "I wish this video didnt have so many ads...");

        videos.Add(video3);

    
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }





    }
}