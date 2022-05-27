using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float _speed = 3f; 
    Rigidbody2D _rb = default;
    Vector2 _input = Vector2.zero;
    GameObject player = default;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player)
        {
            Vector3 enemypos = this.transform.position;
            Vector3 playerpos = player.transform.position;
            float dis = Vector3.Distance(enemypos, playerpos);

            if (dis < 10)
            {
                _input = new Vector2(_speed, _rb.velocity.y);
                _rb.velocity = _input;
            }
        }

        
    }

}
