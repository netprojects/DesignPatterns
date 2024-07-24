public class WAV : IFormat
{
    public void Play(string filePath)
    {
        Console.WriteLine($"Playing WAV file {filePath}");
    }
}