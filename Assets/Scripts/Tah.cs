public class Tah
{
    public XY start;
    public XY end;
    public Figurka enemy;

    public Tah(XY start, XY end, Figurka enemy = null)
    {
        this.start = start;
        this.end = end;
        this.enemy = enemy;
    }

    public override string ToString()
    {
        return $"{start} => {end} Enemy: {enemy}";
    }
}