using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Inventory : MonoBehaviour
{
    public bool selected;
    [SerializeField] private GameObject inventoryCanvas;
    [SerializeField] private GameObject uiCanvas;

    // Start is called before the first frame update
    void Start()
    {
        inventoryCanvas.SetActive(false);
        uiCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            selected = !selected;
            inventoryCanvas.SetActive(selected);
            uiCanvas.SetActive(!selected);
        }
       
    }

   
        
    


}
