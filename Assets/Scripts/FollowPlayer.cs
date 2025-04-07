using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    
    private readonly Vector3 _offset = new(4, 5, -8);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}
