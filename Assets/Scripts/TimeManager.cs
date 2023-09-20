using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public EventManager eventManager;
    public int currentYear = 0; // 현재 연도

    // 게임 시작시 초기화
    void Start()
    {
        currentYear = 0; // 시작 연도 설정
    }

    // "5년을 보낸다" 버튼을 누를 경우 호출될 함수
    public void AdvanceTenYears()
    {
        currentYear += 5; // 5년 증가
    }

    public void OnFiveYearsButtonClicked()
    {
        Debug.Log("5년 버튼이 눌렸습니다.");
        eventManager.TriggerRandomEvent();
    }
}
