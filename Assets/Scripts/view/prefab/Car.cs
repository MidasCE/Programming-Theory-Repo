
using UnityEngine;

public class Car : MonoBehaviour
{
    public string carName;
    public float Speed { get; set;}
    
    public float BackwardSpeed { get; set;}
    public float TurnSpeed { get; set;}

    public virtual void Drive()
    {
        Debug.Log($"{carName} is driving at speed {Speed}.");
    }

    public virtual void Boost()
    {
        Debug.Log($"{carName} uses default boost.");
    }
}
