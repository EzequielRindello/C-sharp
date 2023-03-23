using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos and return a list to iterate through
        List<Video> videos = CreateVideosList();
        // Clear the console
        Console.Clear();
        // Display title of the program
        Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        // Run the program
        Display(videos);
    }

    public static void Display(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length);
            Console.WriteLine("Number of comments: " + video.NumComments());
            Console.WriteLine();
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment._name + ": " + comment._text);
            }
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
    }

    public static List<Video> CreateVideosList()
    {
        // Create videos
        Video video1 = new Video("1,000 Blind People Come for the First Time", "Mr. Beast", 120);
        Video video2 = new Video("Trying Out Every Japanese Candy!", "Pewdipie", 180);
        Video video3 = new Video("HEMOS VUELTO A GARRYS MOD", "Rubius", 202);
        Video video4 = new Video("DOY 300€ AL QUE MÁS ME HAGA REÍR | SI TE RÍES PIERDES 22", "Ibai", 307);

        // Create list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Add comments (These comments are actually real ones!)
        video1.AddComment("H2ODelirious", "I absolutely love this, you are incredible MrBeast!");
        video1.AddComment("123123123123 123123123123 ", "MrBeast secured a VIP spot in heaven.Bro has done so much for people, I'm actually touched.");
        video1.AddComment("Jack May ", "I cant believe people hated on him for this, its one of the most wholesome things Ive seen. Such a great guy");
        video2.AddComment("HiMyNameIsTuva", "Pewds and Joey should do this again but with Swedish candy");
        video2.AddComment("Kat", "Watching two grown men giggling away while eating an entire table of candy is honestly the perfect vibe");
        video2.AddComment("Javiera Sanchez", "We need a swedish candy version, i loved the vibe between this two");
        video3.AddComment("preexx", "Últimamente Rubius nos trae puros juegos nostalgicos y se agradece");
        video3.AddComment("iGxbriiYT_", "Que humilde el editor, dandonos entretenimiento, un like para ese hombre.");
        video3.AddComment("el basurero del maruchan", "Que humilde rubius, dándonos un golpe a la nostalgia a aquella buena época donde se subían videos de esté juego");
        video4.AddComment("MetaBallStudios", "No sé que es más gracioso, los videos o su risa");
        video4.AddComment("SebaX98k", "Que humilde Ibai confundiendo a Costa Rica con República Dominicana");
        video4.AddComment("Cafer", "He llegado tan pronto que todavía no ha llegado el npc de que humilde el gigante noble, saludos desde Ecuador");

        return videos;
    }
}