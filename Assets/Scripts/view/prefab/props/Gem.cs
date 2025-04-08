using UnityEngine;

public class Gem : Prop
{
    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (crashSound != null)
            {
                PlayerAudio.PlayOneShot(crashSound, 0.1f);
            }
            
            PlayerDataService.Instance.AddPlayerScore(10);
            Destroy(gameObject);
        }
    }
}
