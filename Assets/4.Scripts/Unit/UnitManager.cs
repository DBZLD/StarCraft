using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitManager : MonoBehaviour
{
    [SerializeField] private GameObject Marker;
    [SerializeField] private GameObject NameText;
    [SerializeField] private UnitBaseData unitData;
    [SerializeField] private T unit;
    private NavMeshAgent m_NavMestAgent;
    public UnitStatus unitStatus;
    public int unitTeam;

    public string unitName;

    AirGround airGround;   //�̵� ����

    int maxHp;             //ü��
    int Damage;            //���ݷ�
    int Defence;           //����
    float attackSpeed;       //���� �ӵ�
    float attackRange;       //���� ��Ÿ�
    float moveSpeed;         //�̵� �ӵ�

    bool isMagic;        //���� ���
    bool isAttack;       //���� ����

    float maxMp;         //����
    float regenMp;       //���� ���

    private void Awake()
    {
        m_NavMestAgent = GetComponent<NavMeshAgent>();

        Marker.transform.localScale = new Vector3(1.3f, 1.3f, 1);
        Marker.transform.localPosition = new Vector3(0, -transform.lossyScale.y/2 + 0.01f, 0);
        Marker.SetActive(false);

        NameText.transform.localPosition = new Vector3(0, transform.lossyScale.y/2, 0);
        NameText.transform.rotation = Quaternion.Euler(90, 0, 0);

        unitStatus = UnitStatus.Stop;
        unitTeam = 1;
    }
    
    public void MarkedUnit()
    {
        Marker.SetActive(true);
    }

    public void UnMarkedUnit()
    {
        Marker.SetActive(false);
    }
    public void Moveto(Vector3 End)
    {
        m_NavMestAgent.SetDestination(End);
        unitStatus = UnitStatus.Move;
    }

    public void StopMove()
    {
        m_NavMestAgent.ResetPath();
        unitStatus = UnitStatus.Stop;
    }

    public void SetUnitStatus()
    {
        unitName = unitData.unitName; //���� �̸�

        AirGround airGround;   //�̵� ����
        AttackType attackType;  //���� Ÿ��
        UnitSize unitSize;    //���� ũ��
        UnitType unitType;    //���� �Ӽ�

        int costMineral;     //�̳׶� ����
        int costBespeneGas;  //���� ����
        int costSupply;      //�α���
        int productionTime;  //���� �ð�
        int transportSize;   //���� �� ũ��

        float maxHp;             //ü��
        float baseDefense;       //�⺻ ����
        float baseDamage;        //�⺻ ���ݷ�
        float upgradeDefense;    //���׷��̵� �� ����
        float upgradeDamage;     //���׷��̵� �� ���ݷ�
        float attackSpeed;       //���� �ӵ�
        float attackRange;       //���� ��Ÿ�
        float moveSpeed;         //�̵� �ӵ�

        bool isMagic;        //���� ���
        bool isAttack;       //���� ����

        float maxMp;         //����
        float regenMp;       //���� ���
    }
}

internal class T
{

}