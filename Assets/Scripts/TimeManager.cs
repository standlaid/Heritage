using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public EventManager eventManager;
    public int currentYear = 0; // ���� ����

    // ���� ���۽� �ʱ�ȭ
    void Start()
    {
        currentYear = 0; // ���� ���� ����
    }

    // "5���� ������" ��ư�� ���� ��� ȣ��� �Լ�
    public void AdvanceTenYears()
    {
        currentYear += 5; // 5�� ����
    }

    public void OnFiveYearsButtonClicked()
    {
        Debug.Log("5�� ��ư�� ���Ƚ��ϴ�.");
        eventManager.TriggerRandomEvent();
    }
}
