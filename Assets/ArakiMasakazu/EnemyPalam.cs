using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPalam : MonoBehaviour
{
    [SerializeField] int _initHP = 5;

    [SerializeField] GameObject _speedUpPrefab = null;
    [SerializeField] GameObject _powerUpPrefab = null;
    int _hp = 0;
    // Start is called before the first frame update
    void Start()
    {
        _hp = _initHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] Vector3 _offset = new Vector3(2,0);
    public void ChangeHP(int value)
    {
        _hp += value;
        Debug.Log($"ìGåªç›ÇÃHPÅF{ _hp}");
        if(_hp <= 0)
        {
            var ec = GetComponent<EnemyController>();
            if(ec.IsBlack)
            {
                Instantiate(_powerUpPrefab, this.transform.position + _offset, Quaternion.identity);
            }
            else
            {
                Instantiate(_speedUpPrefab, this.transform.position + _offset, Quaternion.identity);
            }
            
            Destroy(this.gameObject);
        }
    }

    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerCircle"))
        {
            audioSource.PlayOneShot(_audioClip);
            var ec = GetComponent<EnemyController>();
            PlayerPalam pp = collision.gameObject.transform.parent.GetComponent<PlayerPalam>();
            if (ec.IsBlack == pp.IsBlack)
            {
                Debug.Log("a");
                ChangeHP(-1);
            }
            else
            {
                Debug.Log("a");
                ChangeHP(-2);
            }
            
        }
    }
}
