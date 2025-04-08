using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    
    private readonly Vector3 _offset = new(0, 5, -8);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + player.transform.rotation * _offset;
        
        Vector3 playerEuler = player.transform.eulerAngles;

        Vector3 newEuler = new Vector3(transform.eulerAngles.x, playerEuler.y, playerEuler.z);

        transform.rotation = Quaternion.Euler(newEuler);
    }
}
