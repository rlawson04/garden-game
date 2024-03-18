using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Inventory : MonoBehaviour
{
    public bool selected;
    [SerializeField] private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonPressed()
    {
        selected = !selected;
        canvas.SetActive(selected);
    }
}
