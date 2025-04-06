using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField] private Car[] cars;

    public Car GetCar() 
    {
        int index = Random.Range(0, cars.Length);
        return cars[index];
    }
    
    public Car GetCar(int index) // POLYMORPHISM
    {
        return cars[index];
    }
}
