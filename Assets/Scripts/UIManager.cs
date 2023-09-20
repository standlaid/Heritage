using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TimeManager timeManager; // TimeManager�� ����
    public TMP_Text yearText; // ������ ǥ���� Text ������Ʈ

    void Update()
    {
        UpdateYearText(); // UI ������Ʈ
    }

    // ���� UI ������Ʈ �Լ�
    void UpdateYearText()
    {
        yearText.text = "Year: " + timeManager.currentYear.ToString();
    }
}
