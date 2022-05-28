using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource hornsound;

    void Start()
    {
        hornsound = GetComponent<AudioSource>();
    }
    //ボタンをクリックした時のスクリプトです。
    public void OnClick()
    {
        hornsound.PlayOneShot(hornsound.clip);
    }

}
