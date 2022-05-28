using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] PlayerPalam playerstate;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameover;
    bool isDeath = false;
    // Start is called before the first frame update
    void Start()
    {
        //isDeath = playerstate.IsDeath;
    }

    // Update is called once per frame
    void Update()
    {
        isDeath = playerstate.IsDeath;
        if (isDeath)
        {
            gameover.SetActive(true);
            player.SetActive(false);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene($"Title");
    }
}
