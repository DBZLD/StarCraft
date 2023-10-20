using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitBaseData", menuName = "ScirptableObjects/UnitBaseData", order = 1)]
public class UnitBaseData : ScriptableObject
{
    public string unitName; //���� �̸�

    public AirGround airGround;   //�̵� ����
    public AttackType attackType;  //���� Ÿ��
    public UnitSize unitSize;    //���� ũ��
    public UnitType unitType;    //���� �Ӽ�

    public int costMineral;     //�̳׶� ����
    public int costBespeneGas;  //���� ����
    public int costSupply;      //�α���
    public int productionTime;  //���� �ð�
    public int transportSize;   //���� �� ũ��

    public float maxHp;             //ü��
    public float baseDefense;       //�⺻ ����
    public float baseDamage;        //�⺻ ���ݷ�
    public float upgradeDefense;    //���׷��̵� �� ����
    public float upgradeDamage;     //���׷��̵� �� ���ݷ�
    public float attackSpeed;       //���� �ӵ�
    public float attackRange;       //���� ��Ÿ�
    public float moveSpeed;         //�̵� �ӵ�

    public bool isMagic;        //���� ���
    public bool isAttack;       //���� ����

    public float maxMp;         //����
    public float regenMp;       //���� ���
}

