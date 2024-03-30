using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDemo : MonoBehaviour
{
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
