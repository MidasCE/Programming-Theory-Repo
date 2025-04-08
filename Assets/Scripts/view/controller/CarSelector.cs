using System;
using UnityEngine;

namespace view.controller
{
    public class CarSelector : MonoBehaviour
    {
        [SerializeField] private Car[] cars;
        
        private float _horizontalInput;
        private int _index = 0;

        public void Start()
        {
            ActivateCar(_index);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                SwitchCar(1);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                SwitchCar(-1);
            }
        }

        public Car GetSelectedCar()
        {
            return cars[_index];
        }
        
        private void SwitchCar(int direction)
        {
            cars[_index].gameObject.SetActive(false);

            _index += direction;

            if (_index >= cars.Length)
            {
                _index = 0;
            }

            if (_index < 0)
            {
                _index = cars.Length - 1;
            }

            ActivateCar(_index);
        }

        private void ActivateCar(int index)
        {
            cars[index].gameObject.SetActive(true);
        }
    }
}