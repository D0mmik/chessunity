using System.Collections.Generic;

public abstract class Figurka
{
    public XY position;
    public Barva barva;
    public abstract List<Tah> GetAvailableMoves(Board board);

    public override string ToString()
    {
        return "Jezdec";
    }
}
