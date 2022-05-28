using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : Singleton<PlaySound>
{
    [SerializeField] AudioSource audioSource = null;

    private void Start()
    {
        if(audioSource)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

}
