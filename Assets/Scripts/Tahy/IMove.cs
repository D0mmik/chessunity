using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    public Dictionary<XY, Figurka> ExecuteMove(Dictionary<XY, Figurka> board);
}
