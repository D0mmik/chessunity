using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    void Start()
    {
        Board board = new();

        for (int i = 0; i < board.boardSize; i++)
        {
            board.AddFigurka(new Pawn(new(i,1), Barva.White));
        }
        board.AddFigurka(new Knight(new XY(1,0), Barva.White));
        

        List<IMove> tahy = board.GetAtPos(new(1, 0)).GetAvailableMoves(board);
        board.board = tahy[0].ExecuteMove(board.board);
        
        tahy = board.GetAtPos(new(2, 2)).GetAvailableMoves(board);


        foreach (IMove tah in tahy)
        {
            Debug.Log(tah);
        }
        
        
    }
}

