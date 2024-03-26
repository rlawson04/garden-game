using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IsInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float interactRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            Debug.DrawRay(InteractorSource.position, InteractorSource.forward, Color.red, 1.0f, false);
            if (Physics.Raycast(r, out RaycastHit hit, interactRange))
            {
                if(hit.collider.gameObject.TryGetComponent(out IsInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}
