using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 mousePos2D;
    Vector3 mousePos3D;

    [SerializeField] private int limitX = 23;
    [SerializeField] private float paddleSpeed = 5;

    void Update()
    {
        // MoveWithKeyboard();
        // MoveWithMouse();
        MoveWithControl();
    }

    // Mueve el paddle con el teclado, ya sea con las flechas o con las teclas a, d
    void MoveWithKeyboard()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.down * paddleSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.up * paddleSpeed * Time.deltaTime);
        }

        Vector3 pos = transform.position;

        if (pos.x < -limitX)
        {
            pos.x = -limitX;
        }
        else if (pos.x > limitX)
        {
            pos.x = limitX;
        }

        this.transform.position = pos;
    }

    void MoveWithMouse()
    {
        mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;

        if (pos.x < -limitX)
        {
            pos.x = -limitX;
        }
        else if (pos.x > limitX)
        {
            pos.x = limitX;
        }

        this.transform.position = pos;
    }

    void MoveWithControl()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * paddleSpeed * Time.deltaTime);
    }
}
