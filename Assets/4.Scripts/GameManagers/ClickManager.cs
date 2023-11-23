using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour
{
    [SerializeField] private LayerMask layerEnemy;
    [SerializeField] private LayerMask layerAlly;
    [SerializeField] private LayerMask layerThird;

    private Camera MainCamera;
    private UnitController m_UnitController;
    private BuildingController m_BuildingCountroller;
    private MaterialController m_MaterialController;

    public int keyInput = 0;

    private void Awake()
    {
        MainCamera = Camera.main;

        m_UnitController = GetComponent<UnitController>();
        m_BuildingCountroller = GetComponent<BuildingController>();
        m_MaterialController = GetComponent<MaterialController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_UnitController.StopSelectedUnit();
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            m_UnitController.HoldSelectedUnit();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            keyInput = 1;
        }
        else if (Input.GetKey(KeyCode.G))
        {
            keyInput = 2;
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            m_UnitController.SelectUnitList[0].nowHp += 10;
        }
        else
        {
            keyInput = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                RaycastHit hit;

                Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerAlly))
                {
                    if (hit.collider.CompareTag("Unit")) // ��Ŭ�� �Ʊ�����Ÿ��
                    {
                        if (hit.transform.GetComponent<UnitManager>() == null) { return; }
                        if (m_BuildingCountroller.SelectingBuilding != null) { m_BuildingCountroller.UnselectBuilding(); }
                        if (m_MaterialController.SelectingMaterial != null) { m_MaterialController.UnselectMaterial(); }

                        if (Input.GetKey(KeyCode.LeftShift))
                        {
                            m_UnitController.ShiftClickSelectUnit(hit.transform.GetComponent<UnitManager>());
                        }
                        else
                        {
                            m_UnitController.ClickSelectUnit(hit.transform.GetComponent<UnitManager>());
                        }
                    }
                    else if (hit.collider.CompareTag("Building"))// ��Ŭ�� �Ʊ��ǹ�Ÿ��
                    {
                        if (hit.transform.GetComponent<BuildingManager>() == null) { return; }
                        if (m_UnitController.SelectUnitList.Count != 0) { m_UnitController.UnselectAll(); }
                        if (m_MaterialController.SelectingMaterial != null) { m_MaterialController.UnselectMaterial(); }

                        m_BuildingCountroller.ClickSelectBuilding(hit.transform.GetComponent<BuildingManager>());
                    }
                }
                else if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerEnemy)) // ��Ŭ�� ��Ŭ��
                {
                    if (m_MaterialController.SelectingMaterial != null) { m_MaterialController.UnselectMaterial(); }
                }
                else if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerThird)) // ��Ŭ�� �߸�������ƮŬ��
                {
                    if (m_BuildingCountroller.SelectingBuilding != null) { m_BuildingCountroller.UnselectBuilding(); }
                    if (m_UnitController.SelectUnitList.Count != 0) { m_UnitController.UnselectAll(); }
                    if(m_MaterialController.SelectingMaterial != null) { m_MaterialController.UnselectMaterial(); }

                    if (!Input.GetKey(KeyCode.LeftShift) && hit.collider.CompareTag("Mineral") || hit.collider.CompareTag("BespeneGas"))
                    {
                        m_MaterialController.ClickSelectMaterial(hit.transform.GetComponent<MaterialManager>());
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                RaycastHit hit;

                Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerThird) && hit.collider.CompareTag("Ground"))
                {
                    if(hit.collider.CompareTag("Ground")) // ��Ŭ�� ��Ÿ��
                    {
                        if (keyInput == 1)
                        {
                            m_UnitController.AttackSelectedUnit(hit.point);
                        }
                        else if (keyInput == 2)
                        {
                            m_UnitController.GatheringSelectedUnit(hit.transform.gameObject);
                        }
                        else if (keyInput == 0)
                        {
                            m_UnitController.MoveSelectedUnit(hit.point);
                        }
                    }
                    else if(hit.collider.CompareTag("Mineral") || hit.collider.CompareTag("BespeneGas")) // ��Ŭ�� �ڿ�Ÿ��
                    {
                        for (int i = 0; i < m_UnitController.CountSelectedUnit(); i++)
                        {
                            if (m_UnitController.SelectUnitList[i].unitData.unitName == UnitName.SCV)
                            {
                                m_UnitController.GatheringSelectedUnit(hit.transform.gameObject, i);
                            }
                            else
                            {
                                m_UnitController.MoveSelectedUnit(hit.transform.gameObject, i);
                            }
                        }
                    }
                }
                else if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerAlly)) // ��Ŭ�� �Ʊ�Ÿ��
                {
                   
                }
                else if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerEnemy)) // ��Ŭ�� ����Ÿ��
                {

                }
            }
        }
    }
}
