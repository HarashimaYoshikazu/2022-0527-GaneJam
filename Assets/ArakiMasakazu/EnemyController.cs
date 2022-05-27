using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float _speed = 3f; 
    Rigidbody2D _rb = default;
    Vector2 _input = Vector2.zero;
    [SerializeField] Collider2D wallChaek;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //_input.x = _speed;
        //Debug.Log(_input);
        //_rb.velocity= _input.normalized;

        _input = new Vector2(_speed, _rb.velocity.y);
        _rb.velocity = _input;
    }
}
