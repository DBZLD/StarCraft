using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AirGround  //�̵� ����
{
    Ground,    //����
    Air,       //����
    Hovering   //����
};
public enum AttackType //���� Ÿ��
{
    Normal,     //�Ϲ�
    Explosive,  //����
    Concussive, //����
    Spell       //����
};
public enum UnitSize   //���� ũ��
{
    Small,  //����
    Medium, //����
    Large   //����
};
public enum UnitType   //���� �Ӽ�
{
    Biological,           //��ü
    Mechanical,           //���
    Robotic,              //�κ�
    SpellCaster,          //����ü
    BiologicalMechanical  //��ü+���
};
public enum UnitStatus //���� ����
{
    Stop,           //����
    Move,           //�̵�
    Attack,         //����
    ForcedAttack,   //���� ����
    Hold,           //Ȧ��
    Patrol          //��Ʈ��
};
