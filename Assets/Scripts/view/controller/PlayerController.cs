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
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _selectedCar.Speed * _forwardInput);   
        }
        
        // Turn (Y-axis only)
        float turnSpeed = _selectedCar.TurnSpeed;
        float turn = _horizontalInput * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}
