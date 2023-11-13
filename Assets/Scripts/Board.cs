using System.Collections.Generic;

public class Board
{
    public Dictionary<XY, Figurka> board = new();
    public int boardSize = 8;

    public void AddFigurka(Figurka figurka)
    {
        board.Add(figurka.position, figurka);
    }

    public Figurka GetAtPos(XY pos)
    {
        return board.TryGetValue(pos, out Figurka result) ? result : null;
    }

    public bool IsPosValid(XY pos)
    {
        return pos.x >= 0 && pos.x < boardSize && pos.y >= 0 && pos.y < boardSize;
    }
}
