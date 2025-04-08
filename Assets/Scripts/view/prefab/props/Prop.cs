
using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Prop : MonoBehaviour
{
    [SerializeField] protected AudioClip crashSound;
    
    protected AudioSource PlayerAudio;
    
    private void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
        }
    }
}
