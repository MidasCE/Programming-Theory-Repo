
using UnityEngine;

public class JapanCar : Car // INHERITANCE
{
    private void Start()
    {
        carName = "Nissan Skyline";
        speed = 180f;
        acceleration = 6.0f;
    }

    public override void Boost()
    {
        Debug.Log($"{carName} activates turbo boost with NOS!");
    }
}
