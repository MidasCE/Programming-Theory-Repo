using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    private float _forwardInput;

    private Car _selectedCar;

    public void SetCar(Car car)
    {
        _selectedCar = car;
    }
    
    void Update()
    {
        if (_selectedCar == null)
        {
            return;
        }
        
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
        // Moves the car based on forward input.

        if (_forwardInput < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _selectedCar.BackwardSpeed * _forwardInput);   
        
            // Moves the car based on horizontal input.
            transform.Rotate(Vector3.down * Time.deltaTime * _selectedCar.TurnSpeed * _horizontalInput);   
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _selectedCar.Speed * _forwardInput);   
        
            // Moves the car based on horizontal input.
            transform.Rotate(Vector3.up * Time.deltaTime * _selectedCar.TurnSpeed * _horizontalInput);   
        }
    }
}
