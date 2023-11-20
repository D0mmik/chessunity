using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Figurka
{
    public Knight(XY pozice, Barva color)
    {
        this.position = pozice;
        this.barva = color;
    }

    public override List<IMove> GetAvailableMoves(Board board)
    {
        List<IMove> tahy = new();
        
        TryAddMove(position + new XY(1,2));
        TryAddMove(position + new XY(2,1));
        TryAddMove(position + new XY(2,-1));
        TryAddMove(position + new XY(1,-2));
        TryAddMove(position + new XY(-1,-2));
        TryAddMove(position + new XY(-2,-1));
        TryAddMove(position + new XY(-2,1));
        TryAddMove(position + new XY(-1,2));
        
        return tahy;

        void TryAddMove(XY end)
        {
            if(!board.IsPosValid(end))
                return;
            
            Figurka enemy = board.GetAtPos(end);
            if (enemy != null && enemy.barva == barva)
                return;
            
            tahy.Add(new StandardMove(position, end));
        }
        
    }
}