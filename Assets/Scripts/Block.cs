using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int endurance = 1;

    void Start()
    {

    }

    void Update()
    {
        if (endurance <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public virtual void BallBounce()
    {

    }
}
