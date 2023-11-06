using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingBaseData", menuName = "ScirptableObjects/BuildingBaseData", order = 1)]
public class BuildingBaseData : ScriptableObject
{
    public BuildingName buildingName;// �̸� 

    public int costMineral;     //�̳׶� ����
    public int costBespeneGas;  //���� ����
    public int productionTime;  //���� �ð�

    public float buildingMaxHp;             //ü��
    public float buildingBaseDefense;       //�⺻ ����

    public bool isAttack;                   //���� ����
    public float buildingBaseDamage;        //�⺻ ���ݷ�
    public float buildingAttackSpeed;       //���� �ӵ�
    public float buildingAttackRange;       //���� ��Ÿ�

}
enum BuildingAirGround  //�̵� ����
{
    Ground,    //����
    Air,       //����
};

