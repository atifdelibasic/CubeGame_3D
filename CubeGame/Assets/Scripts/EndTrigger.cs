using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField]
    private GameManScript gameManager;
    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
