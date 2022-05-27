using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float _speed = 3f;
    Rigidbody2D _rb = default;
    Vector2 _input = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _input.x = _speed;
        Debug.Log(_input);
        _rb.velocity= _input.normalized;
    }
}