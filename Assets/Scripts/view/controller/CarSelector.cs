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
            cars[_index].gameObject.SetActive(true);
        }

        public void Update()
        {
            _horizontalInput = Input.GetAxis("Horizontal");
            
            if ()
        }
    }
}