using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem :ItemBase
{
    [SerializeField] int _addSpeed = 1;
    public override void Execute(GameObject go)
    {
        go.GetComponent<PlayerMove>().AddSpeed(_addSpeed);
        Destroy(this.gameObject);
    }
}

