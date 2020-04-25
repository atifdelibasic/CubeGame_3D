using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;
    [SerializeField]
    [Range(0, 5000)]
    private float forwardForce;
    [SerializeField]
    [Range(0, 1000)]
    private float sidewaysForce;
    [SerializeField]
    public Rigidbody rb;
    private void Start()
    {
        playerMovement.ForwardForce += PlayerMovement_ForwardForce;
        playerMovement.OnLeftKeyPressed += PlayerMovement_OnLeftKeyPressed;
        playerMovement.OnRightKeyPressed += PlayerMovement_OnRightKeyPressed;
    }

    private void PlayerMovement_ForwardForce()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    private void PlayerMovement_OnRightKeyPressed()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    private void PlayerMovement_OnLeftKeyPressed()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

}
