using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private KeyCode Left;
    [SerializeField]
    private KeyCode Right;

    public event Action OnLeftKeyPressed;
    public event Action OnRightKeyPressed;
    public event Action ForwardForce;

    private void FixedUpdate()
    {
        ForwardForce();
        if(Input.GetKey(Left))
        {
            OnLeftKeyPressed();
        }
        if (Input.GetKey(Right))
        {
            OnRightKeyPressed();
        }
        if(transform.position.y <= -1)
        {
            FindObjectOfType<GameManScript>().EndGame();
        }
    }
}
