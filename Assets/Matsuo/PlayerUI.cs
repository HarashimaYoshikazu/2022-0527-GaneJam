
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
//        // �X���C�_�[���擾����
//        lifeber = GameObject.Find("LifeBer").GetComponent<Slider>();
//        expber = GameObject.Find("EXPbar").GetComponent<Slider>();
//        levelui.GetComponent<Text>().text = "Level:" + playerLevel;
//        maxHp = player.playerMaxLife;
//        hp = player.playerLife;

//        �X���C�_�[�̍ő�l�̐ݒ�
//        lifeber.maxValue = maxHp;
//        �X���C�_�[�̌��ݒl�̐ݒ�
//        lifeber.value = hp;
//    }


//    void Update()
//    {
//        maxHp = player.playerMaxLife;
//        hp = player.playerLife;

//        �X���C�_�[�̍ő�l�̐ݒ�
//        lifeber.maxValue = maxHp;

//        �X���C�_�[�̌��ݒl�̐ݒ�
//        lifeber.value = hp;
//        life.text = "LIFE:" + hp + "/" + maxHp;
//    }
//}