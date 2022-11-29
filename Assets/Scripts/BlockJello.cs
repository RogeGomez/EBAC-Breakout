using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockJello : Block
{
    void Start()
    {
        endurance = 2;
    }

    public override void BallBounce()
    {
        base.BallBounce();
    }
}
