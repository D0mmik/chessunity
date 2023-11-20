using System.Collections;
using System.Collections.Generic;

public class Pawn : Figurka
{
    public Pawn(XY position, Barva barva)
    {
        this.position = position;
        this.barva = barva;
    }

    public override List<IMove> GetAvailableMoves(Board board)
    {
        List<IMove> tahy = new();

        int yDirection = barva == Barva.White ? 1 : -1;


        TryAddMove(position + new XY(0,yDirection), false);
        
        if ((barva == Barva.White && position.y == 1) ||
            (barva == Barva.Black && position.y == board.boardSize - 2))
            TryAddMove(position + new XY(0,yDirection * 2), false);

        TryAddMove(position + new XY(1,yDirection), true);
        TryAddMove(position + new XY(-1, yDirection), true);

        return tahy;
        
        void TryAddMove(XY end, bool requireKill)
        {
            if(!board.IsPosValid(end))
                return;
            
            Figurka enemy = board.GetAtPos(end);

            if (requireKill == (enemy != null && enemy.barva == barva))
                tahy.Add(new StandardMove(position, end));
        }
    }

}
