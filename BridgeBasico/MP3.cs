public class MP3 : IFormat
{
    public void Play(string filePath)
    {
        Console.WriteLine($"Playing MP3 file {filePath}");
    }
}