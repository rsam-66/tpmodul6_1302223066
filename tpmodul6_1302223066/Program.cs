using System;

class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Reimark Samuel");
        for (int i = 0; i < 10000000; i++)
        {
            video.IncreasePlayCount(1);
        }

        video.PrintVideoDetails();
    }
}
class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = RandomNumber();
        this.title = title;
        this.playCount = 0;
    }

    private int RandomNumber()
    {
        Random random = new Random();
        return random.Next(00000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount = count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID    : " + this.id);
        Console.WriteLine("Title : " + this.title);
        Console.WriteLine("Play Count : " + this.playCount);
    }
}