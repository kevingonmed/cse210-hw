public class Reference
{
    public string Verse { get; }

    public Reference(string verse)
    {
        Verse = verse;
    }

    public override string ToString()
    {
        return Verse;
    }
}
