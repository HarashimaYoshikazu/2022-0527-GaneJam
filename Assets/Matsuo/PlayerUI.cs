
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] PlayerPalam player;
    [SerializeField] Slider hpbar = default;
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI atkText;

    int maxHp;
    int hp;
    int atk;
    int speed;
    void Start()
    {
        // スライダーを取得する
        maxHp = player.InitHP;
        hp = player.HP;
        //atk = player.ATK;

        //スライダーの最大値の設定
        hpbar.maxValue = maxHp;
        //スライダーの現在値の設定
        hpbar.value = hp;
    }


    void Update()
    {
        maxHp = player.InitHP;
        hp = player.HP;

        //スライダーの最大値の設定
        hpbar.maxValue = maxHp;

        //スライダーの現在値の設定
        hpbar.value = hp;
        //speedText.text = "SPEED:" + speed;
        atkText.text = "ATK:" + atk;
    }
}