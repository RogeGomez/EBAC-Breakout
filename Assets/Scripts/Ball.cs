using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isGameStarted = false;
    [SerializeField] private float ballSpeed = 10.5f;

    void Start()
    {
        Vector3 initialPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        initialPosition.y += 3;
        this.transform.position = initialPosition;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
    }

    void Update()
    {
        MoveBallSpace();
    }

    // La bola sale disparada del paddle al apretar la tecla space o al apretar a en el control
    private void MoveBallSpace()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = ballSpeed * Vector3.up;
            }
        }
    }
}
