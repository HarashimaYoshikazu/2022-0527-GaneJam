using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPalam : MonoBehaviour
{
    [SerializeField] int _hp = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_hp<=0)
        {
            Debug.Log("GameOver");
        }
    }
    public void Damage()
    {
        _hp--;
    }
}
