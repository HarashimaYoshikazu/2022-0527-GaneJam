using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : ItemBase
{
    [SerializeField]
    int _addPower = 1;
    public override void Execute(GameObject go)
    {
        //çUåÇóÕÇUP
        go.GetComponent<PlayerPalam>().ChangeAtk(_addPower);
        this.GetComponent<Collider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
        PlayerPalam.Instance.PlayPerticl(false,true);
    }

    protected override void DelayExecute(GameObject go)
    {
        go.GetComponent<PlayerPalam>().ChangeAtk(-(_addPower));
        PlayerPalam.Instance.PlayPerticl(false, false);
    }
}
