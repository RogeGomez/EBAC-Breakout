using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSubscriptor : MonoBehaviour
{
    ShowEvents subscriptor;

    private void Start()
    {
        subscriptor = GetComponent<ShowEvents>();
        subscriptor.OnSpacePressed += MessageListenedByTheSubscriptor;
    }

    private void MessageListenedByTheSubscriptor(object sender, EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado desde otra clase");
        subscriptor.OnSpacePressed -= MessageListenedByTheSubscriptor;
    }
}
