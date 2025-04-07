
using UnityEngine;

public class JapanCar : Car // INHERITANCE
{
    private void Start()
    {
        carName = "Nissan Skyline";
        Speed = 180f;
        BackwardSpeed = 90f;
        TurnSpeed = 6.5f;
    }

    public override void Boost()
    {
        Debug.Log($"{carName} activates turbo boost with NOS!");
    }
}
