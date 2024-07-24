public abstract class Monster:IClonable
{
    public int Id{get;set;}
    public string Name{get;set;}

public abstract void Attak();
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}