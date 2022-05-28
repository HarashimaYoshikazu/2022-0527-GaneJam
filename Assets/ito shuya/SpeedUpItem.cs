using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem :ItemBase
{
    [SerializeField] int _addSpeed = 1;
    public override void Execute(GameObject go)
    {
        go.transform.GetComponent<PlayerMove>().ChangeSpeed(_addSpeed);
        this.GetComponent<Collider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
    }
    protected override void DelayExecute(GameObject go)
    {
        go.transform.GetComponent<PlayerMove>().ChangeSpeed(-(_addSpeed));
    }
}

