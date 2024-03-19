using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject _mainCamera;
    [SerializeField] private GameObject _playerCamera;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _jumpForce = 200;



    private bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            isSelected = !isSelected;
        }
        _mainCamera.SetActive(isSelected);
        _playerCamera.SetActive(!isSelected);

        var vel = new Vector3(Input.GetAxis("Horizontal") * _speed, 0, Input.GetAxis("Vertical") * _speed);
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * _jumpForce);
        }
        
    }
}
