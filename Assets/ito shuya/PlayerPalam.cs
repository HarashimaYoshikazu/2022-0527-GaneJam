using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPalam : MonoBehaviour
{
    [SerializeField] int _initHP = 5;
    public int InitHP => _initHP;

    int _hp = 0;
    public int HP => _hp;
    
    [SerializeField] int _atk = 1;

    bool isBlack = false;
    public bool IsBlack => isBlack;

    SpriteRenderer _spriteRenderer = default;
    void Start()
    {
        _hp = _initHP;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (_hp <= 0)
        {
            Debug.Log("GameOver");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            isBlack = !isBlack;
            SetColor();
        }
    }
    public void Damage(int dmg)
    {
        if(_hp -dmg >=_initHP)
        {
            _hp = _initHP;
        }
        else
        {
            _hp -= dmg;
        }
        
        Debug.Log($"ダメージを受けた！現在のHP：{_hp}");
    }
    public void AddAtk(int atk)
    {
        _atk += atk;
        Debug.Log($"攻撃力上がった：{ _atk}");
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
}
