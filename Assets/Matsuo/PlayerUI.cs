
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
        // �X���C�_�[���擾����
        maxHp = player.InitHP;
        hp = player.HP;
        //atk = player.ATK;

        //�X���C�_�[�̍ő�l�̐ݒ�
        hpbar.maxValue = maxHp;
        //�X���C�_�[�̌��ݒl�̐ݒ�
        hpbar.value = hp;
    }


    void Update()
    {
        maxHp = player.InitHP;
        hp = player.HP;

        //�X���C�_�[�̍ő�l�̐ݒ�
        hpbar.maxValue = maxHp;

        //�X���C�_�[�̌��ݒl�̐ݒ�
        hpbar.value = hp;
        //speedText.text = "SPEED:" + speed;
        atkText.text = "ATK:" + atk;
    }
}