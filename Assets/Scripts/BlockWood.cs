using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockWood : Block
{
    void Start()
    {
        endurance = 3;
    }

    public override void BallBounce()
    {
        base.BallBounce();
    }
}
