using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScean : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TestCean");
    }

}