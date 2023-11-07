using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "BuildingBaseData", menuName = "ScirptableObjects/BuildingBaseData", order = 1)]
public class BuildingBaseData : ScriptableObject
{
    public BuildingName buildingName;// �̸� 

    public ObjectSize buildingSize;
    public ObjectType buildingType;

    public int costMineral;     //�̳׶� ����
    public int costBespeneGas;  //���� ����
    public int productionTime;  //���� �ð�

    public float buildingMaxHp;             //ü��
    public float buildingBaseDefense;       //�⺻ ����

    public bool isAttack;                   //���� ����
    public float buildingBaseDamage;        //�⺻ ���ݷ�
    public float buildingAttackSpeed;       //���� �ӵ�
    public float buildingAttackRange;       //���� ��Ÿ�

    public KeyCodeList[] keyCodeList;
}
