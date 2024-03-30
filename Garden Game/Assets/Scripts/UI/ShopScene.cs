using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScene : MonoBehaviour
{
    [SerializeField] private string shop = "Growing";

    public void ShopSceneButton()
    {
        SceneManager.LoadScene(shop, LoadSceneMode.Single);
    }

}
