using System;
using System.Diagnostics.Contracts;

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

        Contract.Requires(this.title != null && title.Length <= 100);
    }

    private int RandomNumber()
    {
        Random random = new Random();
        return random.Next(00000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count > 0 && count <= 10000000);
        Contract.Requires(playCount <= int.MaxValue - count);
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Play count melebihi batas");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID    : " + this.id);
        Console.WriteLine("Title : " + this.title);
        Console.WriteLine("Play Count : " + this.playCount);
    }
}