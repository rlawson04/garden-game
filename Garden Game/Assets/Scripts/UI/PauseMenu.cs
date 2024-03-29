using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject shopCanvas;
    [SerializeField] private GameObject teleportCanvas;
    [SerializeField] private GameObject inventoryCanvas;

    // Update is called once per frame
    void Update()
    {
        if (menuCanvas.activeInHierarchy || shopCanvas.activeInHierarchy || teleportCanvas.activeInHierarchy || inventoryCanvas.activeInHierarchy)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
    void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

    }
}
