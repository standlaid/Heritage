using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    public PlayerManager playerManager; // PlayerManager 참조

    public GameObject eventPanel;
    public TMP_Text eventDescription;
    public Button[] choiceButtons;
    public GameObject feedbackPanel;
    public TMP_Text feedbackText;
    private void Start()
    {
        // 초기에는 패널을 끕니다.
        eventPanel.SetActive(false);
        feedbackPanel.SetActive(false);
    }

    public void TriggerRandomEvent()
    {
        // 랜덤 이벤트를 불러옵니다 (이 부분은 나중에 복잡한 로직으로 바꿀 수 있습니다)
        string randomEvent = "무슨 일이 발생했습니다.";
        string[] choices = { "선택 1", "선택 2", "선택 3" };

        eventDescription.text = randomEvent;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            choiceButtons[i].GetComponentInChildren<TMP_Text>().text = choices[i];
            choiceButtons[i].onClick.AddListener(() => OnChoiceMade(i));
        }

        eventPanel.SetActive(true);
    }

    public void OnChoiceMade(int choiceIndex)
    {
        // 여기서 선택에 따른 로직을 실행합니다.
        // 예를 들어, 선택에 따라 게임 내 변수를 변경하거나 새 이벤트를 트리거할 수 있습니다.

        feedbackText.text = "당신의 선택은 " + choiceIndex + "번째 선택지입니다.";
        feedbackPanel.SetActive(true);

        eventPanel.SetActive(false);
    }
    public void HandleMarriage()
    {
    
    }

    public void HandleSickness()
    {
        
    }
   

}



