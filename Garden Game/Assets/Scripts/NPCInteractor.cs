using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteractor : MonoBehaviour, IsInteractable
{
    [SerializeField] private GameObject shopCanvas;
    [SerializeField] public GameObject text;
    [SerializeField] public Interactor interactor;

    public void Interact()
    {
        shopCanvas.SetActive(true);
    }

    public void Show()
    {
        text.SetActive(true);
    }
    public void Hide()
    {
        text.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactor.GetInteractable() != null)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }
}
