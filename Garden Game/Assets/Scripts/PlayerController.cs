using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _jumpForce = 200;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        if(direction.magnitude > 0.1f)
        {
            controller.Move(direction * _speed * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
         
        }
        
    }
}
