using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "UnitBaseData", menuName = "ScirptableObjects/UnitBaseData", order = 1)]
public class UnitBaseData : ScriptableObject
{
    public UnitName unitName; //���� �̸�

    public AirGround airGround;    //�̵� ����
    public AttackType attackType;  //���� Ÿ��
    public ObjectSize unitSize;      //���� ũ��
    public ObjectType unitType;      //���� �Ӽ�
    public MaterialType materialType;//�ڿ� ����

    public int costMineral;     //�̳׶� ����
    public int costBespeneGas;  //���� ����
    public int costSupply;      //�α���
    public int productionTime;  //���� �ð�
    public int transportSize;   //���� �� ũ��
    public int uiPriority;      //��ư UI �켱����
    public int maxHp;           //ü��
    public int baseDefense;     //�⺻ ����
    public int baseDamage;      //�⺻ ���ݷ�
    public int upgradeDefense;  //���׷��̵� �� ����
    public int upgradeDamage;   //���׷��̵� �� ���ݷ�
    public int nowHp;           //���� ü��
    public int nowDefense;      //���� ����
    public int nowDamage;       //���� ���ݷ�
    public float attackSpeed;   //���� �ӵ�
    public float attackRange;   //���� ��Ÿ�
    public float moveSpeed;     //�̵� �ӵ�

    public bool isMagic;        //���� ���
    public bool isAttack;       //���� ����

    public int maxMp;           //����
    public int nowMp;           //���� ����
    public float regenMp;       //���� ���

    public KeyCodeList[] keyCodeList;
}
[Serializable]
public class KeyCodeList
{
    public int[] keyCode;
    public int[] buttonCode;
}

