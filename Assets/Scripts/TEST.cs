using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    void Start()
    {
        Board board = new();
        board.AddFigurka(new Knight(new XY(1,0), Barva.White));

        List<Tah> tahy = board.GetAtPos(new(1, 0)).GetAvailableMoves(board);

        foreach (Tah tah in tahy)
        {
            Debug.Log(tah);
        }
    }
}

