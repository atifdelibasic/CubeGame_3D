using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text coinText;
    private void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
