using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject player;

    private bool selected;

    // Start is called before the first frame update
    void Start()
    {
        selected = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            selected = !selected;
        }
        mainCamera.SetActive(selected);
        playerCamera.SetActive(!selected);

        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position -= Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.rotation = Quaternion.LookRotation(-Vector3.forward, Vector3.up);
        }
    }
}
