using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItem : ItemBase
{
    [SerializeField]
    int _addPower = 1;
    public override void Execute(GameObject go)
    {
        go.GetComponent<PlayerPalam>().AddAtk(_addPower);
        Destroy(this.gameObject);
    }
}
