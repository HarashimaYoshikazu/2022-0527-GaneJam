using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float _speed = 3f; 
    Rigidbody2D _rb = default;
    Vector2 _input = Vector2.zero;
    GameObject player = default;

    [SerializeField] int _damage = 1;

    [SerializeField] bool isBlack = false;
    public bool IsBlack => isBlack;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();

        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        if(isBlack)
        {
            sp.color = Color.black;
        }
        else
        {
            sp.color = Color.white;
        }
        
    }

    void Update()
    {
            Vector3 enemypos = this.transform.position;
            Vector3 playerpos = GameObject.FindGameObjectWithTag("Player").transform.position;
            float dis = Vector3.Distance(enemypos, playerpos);

            if (dis < 10)
            {
                _rb.velocity = (playerpos - this.transform.position).normalized * _speed;
            }       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPalam pp = collision.GetComponent<PlayerPalam>();
            //エネミーの属性とプレイヤーの属性が一緒だったら
            if(isBlack == pp.IsBlack)
            {
                pp?.Damage(_damage);
            }
            else 
            {
                pp?.Damage(_damage *2);
            }
            

        }
    }

}
