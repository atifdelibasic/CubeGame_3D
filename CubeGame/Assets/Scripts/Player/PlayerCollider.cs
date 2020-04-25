using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour
{
    //[SerializeField]
    //private PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            // two ways 
            //movement.enabled = false;
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManScript>().EndGame();
        }
    }
}
