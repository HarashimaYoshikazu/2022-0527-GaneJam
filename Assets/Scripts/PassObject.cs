using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassObject : MonoBehaviour
{
    [SerializeField] Collider2D _collider = null;
    [SerializeField] SpriteRenderer _spriteRenderer = null;
    [SerializeField] bool isBlack = false;
    void Start()
    {
        if(!_collider)
        {
            _collider = GetComponent<Collider2D>();
        }
        if(!_spriteRenderer)
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        if(isBlack)
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
        if (collision.gameObject.CompareTag("PlayerBody"))
        {
            
            var palam = collision.gameObject.GetComponentInChildren<PlayerPalam>();
           if(palam.IsBlack ==isBlack)
            {
                _collider.isTrigger = true;
            }
            
        }
    }


}
