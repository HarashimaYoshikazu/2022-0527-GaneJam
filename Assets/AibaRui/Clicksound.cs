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
    //�{�^�����N���b�N�������̃X�N���v�g�ł��B
    public void OnClick()
    {
        hornsound.Play();
    }

}