using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager instance;
    public AudioSource coinsource;
    public AudioClip coinSound;
    public AudioClip magnetsound;
    public AudioClip jumpSound;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinsource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   
}
