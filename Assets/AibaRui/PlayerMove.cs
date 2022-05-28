using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 10f;
    [SerializeField] float _jumppower = 10f;

    int _jumpcount=0;
    private bool _jump = false;
    Rigidbody2D _rb = default;
    Animator _anim;

    [SerializeField] PlayerAttackColor _attackcolor;

    private bool _ground = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

         Move();
        Jump();
        Attack();

        //if(Input.GetButtonDown("Jump"))
        //{
        //    if (_jumpcount < 2)
        //    {
        //        _jump = true;
        //    }

        //}


    }

    private void FixedUpdate()
    {
        
        //if(_jump)
        //{
        //    _rb.AddForce(Vector2.up * _jumppower, ForceMode2D.Impulse);
            
        //    _jumpcount++;
        //    _jump = false;
        //}

    }


     void Move()
    {
        float _h = Input.GetAxisRaw("Horizontal");


        Vector2 velo = new Vector2(_h * _speed, _rb.velocity.y);
        _rb.velocity = velo;

        if(_h !=0)
        {
            if(_h<0)
            {
                this.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                this.transform.localScale = new Vector3(1, 1, 1);
            }


        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump")&&_ground)
        {
            _rb.AddForce(Vector2.up * _jumppower, ForceMode2D.Impulse);
            _ground = false;
        }

    }

    void Attack()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            _anim.SetTrigger("Attack");
            if (_attackcolor)
            {
                _attackcolor.SetColor();
            }
            else
            {
                Debug.LogError("PlayerMoveクラスにPlayerAttackColorがアタッチされていません。");
            }
        }
    }
    public void ChangeSpeed(int spd)
    {
        _speed += spd;
        Debug.Log($"スピード変わった：{_speed}");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _ground = true;
           // _jumpcount = 0;
        }

    }

}

