using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPalam : MonoBehaviour
{
    [SerializeField] int _hp = 5;
    [SerializeField] int _atk = 1;

    bool isBlack = false;
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

        if(Input.GetKeyDown(KeyCode.Q))
        {
            isBlack = !isBlack;
        }
    }
    public void Damage(int dmg)
    {
        _hp-= dmg;
    }
    public void AddAtk(int atk)
    {
        _atk += atk;
    }
}
