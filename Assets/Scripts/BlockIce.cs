using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockIce : Block
{
    void Start()
    {
        endurance = 4;
    }

    public override void BallBounce()
    {
        base.BallBounce();
    }
}
