public class DesktopPlayer : MusicPlayer
{
    private readonly IFormat _format;
    public DesktopPlayer(IFormat format):base (format)
    {
        this._format = format;
    }
    public override void Play(string filePath)
    {
       Console.WriteLine("Using Desktop Player");
    }
}