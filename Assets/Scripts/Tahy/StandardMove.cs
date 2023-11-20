using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMove : IMove
{
    public XY start;
    public XY end;

    public StandardMove(XY start, XY end)
    {
        this.start = start;
        this.end = end;
    }

    public Dictionary<XY, Figurka> ExecuteMove(Dictionary<XY, Figurka> board)
    {
        board[end] = board[start];
        board[end].position = end;
        board[start] = null;

        return board;
    }

    public override string ToString()
    {
        return $"Start: {start} a konec: {end}";
    }
}
