using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScript : MonoBehaviour
{
    private int coinsPicked = 0;
    private AudioSource audio;
    [SerializeField]
    private Score score;
    // Update is called once per frame
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        transform.Rotate(360 * Time.deltaTime, 0 , 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        Destroy(gameObject);
    }
}
