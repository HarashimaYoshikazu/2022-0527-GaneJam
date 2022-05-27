using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPalam : MonoBehaviour
{
    [SerializeField] int _initHP = 5;
    int _hp = 0;
    // Start is called before the first frame update
    void Start()
    {
        _hp = _initHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeHP(int value)
    {
        _hp += value;
        Debug.Log($"åªç›ÇÃHPÅF{ _hp}");
        if(_hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerCircle"))
        {
            ChangeHP(-1);
        }
    }
}
