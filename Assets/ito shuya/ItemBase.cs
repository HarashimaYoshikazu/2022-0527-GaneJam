using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] float _delyTime = 5f;
    public abstract void Execute(GameObject go);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Execute(collision.gameObject);
            StartCoroutine(Corutine(collision.gameObject));
        }
    }

    protected virtual void DelayExecute(GameObject go)
    {

    }

    protected IEnumerator Corutine(GameObject go)
    {
        yield return new WaitForSeconds(_delyTime);
        DelayExecute(go);
        Destroy(this.gameObject);
    }
}
