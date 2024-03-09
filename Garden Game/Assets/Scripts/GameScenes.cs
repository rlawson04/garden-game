using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private string newGame = "Growing";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGame);
    }
    
}
