
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class PlayerUI : MonoBehaviour
//{
//    [SerializeField] PlayerPalam player;
//    [SerializeField] Slider lifeber = default;
//    [SerializeField] TextMeshProUGUI life;
//    int maxHp;
//    int hp;
//    void Start()
//    {
//        // スライダーを取得する
//        lifeber = GameObject.Find("LifeBer").GetComponent<Slider>();
//        expber = GameObject.Find("EXPbar").GetComponent<Slider>();
//        levelui.GetComponent<Text>().text = "Level:" + playerLevel;
//        maxHp = player.playerMaxLife;
//        hp = player.playerLife;

//        スライダーの最大値の設定
//        lifeber.maxValue = maxHp;
//        スライダーの現在値の設定
//        lifeber.value = hp;
//    }


//    void Update()
//    {
//        maxHp = player.playerMaxLife;
//        hp = player.playerLife;

//        スライダーの最大値の設定
//        lifeber.maxValue = maxHp;

//        スライダーの現在値の設定
//        lifeber.value = hp;
//        life.text = "LIFE:" + hp + "/" + maxHp;
//    }
//}