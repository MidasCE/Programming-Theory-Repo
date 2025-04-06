
using UnityEngine;

public class Car : MonoBehaviour
{
    public string carName;
    public float speed;
    public float acceleration;

    public virtual void Drive()
    {
        Debug.Log($"{carName} is driving at speed {speed}.");
    }

    public virtual void Boost()
    {
        Debug.Log($"{carName} uses default boost.");
    }
}
