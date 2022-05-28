using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPalam : Singleton<PlayerPalam>
{
    [SerializeField] int _initHP = 5;
    public int InitHP => _initHP;
   
    int _hp = 0;
    public int HP => _hp;

    [SerializeField] int _atk = 1;

    public int ATK => _atk;

    bool isBlack = false;
    public bool IsDeath => isDeath;

    bool isDeath = false;
    public bool IsBlack => isBlack;

    SpriteRenderer _spriteRenderer = default;

    Animator _anim;
    [SerializeField] PlayerAttackColor _attackcolor;

    [SerializeField] ParticleSystem _SpeedParticleSystem;
    [SerializeField] ParticleSystem _powerParticleSystem;

    void Start()
    {
        _hp = _initHP;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        if (_hp <= 0)
        {
            Debug.Log("GameOver");
            isDeath = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("isBlack");
            isBlack = !isBlack;
            SetColor();
        }
    }

    public void PlayPerticl(bool isSpeed, bool isplay)
    {
        if (isplay)
        {
            if (isSpeed)
            {
                _SpeedParticleSystem.Play();
            }
            else
            {
                _powerParticleSystem.Play();
            }
        }
        else
        {
            if (isSpeed)
            {
                _SpeedParticleSystem.Stop();
            }
            else
            {
                _powerParticleSystem.Stop();
            }
        }
    }
    public void Damage(int dmg)
    {
        if (_hp - dmg >= _initHP)
        {
            _hp = _initHP;
        }
        else
        {
            _hp -= dmg;
        }

        Debug.Log($"ダメージを受けた！現在のHP：{_hp}");
    }
    public void ChangeAtk(int atk)
    {
        _atk += atk;
        Debug.Log($"攻撃力上がった：{_atk}");
    }
    void SetColor()
    {
        if (isBlack)
        {
            _spriteRenderer.color = Color.black;
        }
        else
        {
            _spriteRenderer.color = Color.white;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            _hp = 0;
            isDeath = true;
        }

    }
    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioSource audioSource;
    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            audioSource.PlayOneShot(_audioClip);
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
}
