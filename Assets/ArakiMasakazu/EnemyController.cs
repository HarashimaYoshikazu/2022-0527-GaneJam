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

    private void FixedUpdate()
    {
        if (!Gamemanager.Instance.IsDeath)
        {
            Vector3 enemypos = this.transform.position;
            Vector3 playerpos = GameObject.FindGameObjectWithTag("Player").transform.position;
            float dis = Vector3.Distance(enemypos, playerpos);

            enemypos.y = Vector2.zero.y;
            playerpos.y = Vector2.zero.y;
            if (dis < 10)
            {
                _rb.velocity = (playerpos - enemypos).normalized * _speed;
            }
        }
        
    }
    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioSource _audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBody"))
        {
            _audioSource.PlayOneShot(_audioClip);
            PlayerPalam pp = collision.transform.parent.GetComponent<PlayerPalam>();

            //�G�l�~�[�̑����ƃv���C���[�̑������ꏏ��������
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
