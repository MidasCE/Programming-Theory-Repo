
using UnityEngine;

public class EuroCar : Car // INHERITANCE
{
    private void Start()
    {
        carName = "BMW M3";
        speed = 160f;
        acceleration = 5.5f;
    }

    public override void Boost()
    {
        Debug.Log($"{carName} engages dynamic performance mode.");
    }
}
