using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicksound : MonoBehaviour
{
    private AudioSource hornsound;

    void Start()
    {
        hornsound = GetComponent<AudioSource>();
    }
    //ボタンをクリックした時のスクリプトです。
    public void OnClick()
    {
        hornsound.Play();
    }

}