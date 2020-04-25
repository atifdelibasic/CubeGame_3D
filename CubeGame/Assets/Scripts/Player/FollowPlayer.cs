
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;

    // Update is called once per frame
    private void Update() {
        transform.position = player.position + offset;
    }
}
