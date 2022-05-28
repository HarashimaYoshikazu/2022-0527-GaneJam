using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackColor : MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] PlayerPalam _playerPalam;

    private void Start()
    {
        if (!_spriteRenderer)
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        if (!_playerPalam)
        {
            _playerPalam = this.transform.parent.GetComponent<PlayerPalam>();
        }
    }

    public void SetColor()
    {
        if (_playerPalam.IsBlack)
        {
            _spriteRenderer.color = Color.black;
        }
        else
        {
            _spriteRenderer.color = Color.white;
        }
        
    }
}
