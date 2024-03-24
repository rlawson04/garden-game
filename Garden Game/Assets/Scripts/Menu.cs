using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    bool is_selected;
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject uiCanvas;
    [SerializeField] private GameObject teleportCanvas;


    // Start is called before the first frame update
    void Start()
    {
        menuCanvas.SetActive(false);
        uiCanvas.SetActive(true);
        teleportCanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            is_selected = !is_selected;
            menuCanvas.SetActive(is_selected);
            uiCanvas.SetActive(!is_selected);
        }
    }

    public void CloseMenu()
    {
        is_selected = !is_selected;
        menuCanvas.SetActive(is_selected);
        uiCanvas.SetActive(!is_selected);
    }

    public void OpenTeleportMenu()
    {
        teleportCanvas.SetActive(true);
    }

    public void CloseTeleportMenu()
    {
        teleportCanvas.SetActive(false);
    }
}
