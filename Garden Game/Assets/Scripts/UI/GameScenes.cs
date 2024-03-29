using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private string newGame = "Growing";
    [SerializeField] private string menu = "Game Intro";


    public void NewGameButton()
    {
        SceneManager.LoadScene(newGame);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(menu);
    }

}
