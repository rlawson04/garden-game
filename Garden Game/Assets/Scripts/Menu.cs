using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public bool selected;
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject uiCanvas;

    // Start is called before the first frame update
    void Start()
    {
        menuCanvas.SetActive(false);
        uiCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            selected = !selected;
            menuCanvas.SetActive(selected);
            uiCanvas.SetActive(!selected);
        }

    }
}
