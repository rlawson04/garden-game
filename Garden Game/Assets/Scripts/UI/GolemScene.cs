using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GolemScene : MonoBehaviour
{
    [SerializeField] private string golem = "Golem Scene";

    public void GolemSceneButton()
    {
        SceneManager.LoadScene(golem, LoadSceneMode.Additive);
    }

}
