using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Instantiate( item,new Vector2(0, 0),Quaternion.identity);
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.comp)
    //}
}
