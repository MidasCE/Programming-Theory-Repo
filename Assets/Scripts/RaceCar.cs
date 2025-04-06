
using UnityEngine;

public class RaceCar : Car // INHERITANCE
{
    private void Start()
    {
        carName = "Formula 1";
        speed = 300f;
        acceleration = 3.2f;
    }

    public override void Boost()
    {
        Debug.Log($"{carName} hits DRS and rocket boost!");
    }

    public override void Drive()
    {
        base.Drive();
        Debug.Log($"{carName} is hugging the corners with insane grip!");
    }
}
