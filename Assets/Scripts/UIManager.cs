using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TimeManager timeManager; // TimeManager의 참조
    public TMP_Text yearText; // 연도를 표시할 Text 컴포넌트

    void Update()
    {
        UpdateYearText(); // UI 업데이트
    }

    // 연도 UI 업데이트 함수
    void UpdateYearText()
    {
        yearText.text = "Year: " + timeManager.currentYear.ToString();
    }
}
