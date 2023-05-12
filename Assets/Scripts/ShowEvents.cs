using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEvents : MonoBehaviour
{
    public event EventHandler OnSpacePressed;

    private void Start()
    {
        OnSpacePressed += ListenedEvent;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
    }

    public void ListenedEvent(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho correctamente");
    }
}
