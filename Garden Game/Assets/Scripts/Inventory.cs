using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Inventory : MonoBehaviour
{
    public bool selected;
    [SerializeField] private GameObject storeCanvas;
    [SerializeField] private GameObject inventoryCanvas;

    // Start is called before the first frame update
    void Start()
    {
        storeCanvas.SetActive(false);
        inventoryCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoreButtonPressed()
    {
        selected = !selected;
        storeCanvas.SetActive(selected);
        inventoryCanvas.SetActive(!selected);
    }


}
