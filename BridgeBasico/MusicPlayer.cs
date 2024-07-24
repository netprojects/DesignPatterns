public abstract class MusicPlayer 
{
    protected IFormat _format;

    public MusicPlayer(IFormat format)
    {
        this._format = format;
    }
    public abstract void Play(string filePath);
}