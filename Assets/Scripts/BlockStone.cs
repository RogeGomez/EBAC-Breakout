using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockStone : Block
{
    void Start()
    {
        endurance = 5;
    }

    public override void BallBounce()
    {
        base.BallBounce();
    }
}
