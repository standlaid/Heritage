using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    public PlayerManager playerManager; // PlayerManager 참조

    public GameObject eventPanel;
    public GameObject feedbackPanel;
    public TMP_Text eventDescription;
    public Button[] choiceButtons;
    
    public TMP_Text feedbackText;

    public EventData[] allEvents;
    private readonly List<int>[] choiceOutcomeIndices = {
        new List<int> {0, 1},
        new List<int> {2, 3},
        new List<int> {4, 5} 
    };
    private EventData selectedEvent;


    private void Start()
    {
        // 초기에는 패널을 끕니다.
        eventPanel.SetActive(false);
        feedbackPanel.SetActive(false);
    }

    public void TriggerRandomEvent()
    {
        
        // 랜덤한 이벤트를 선택
        int randomIndex = Random.Range(0, allEvents.Length);
        selectedEvent = allEvents[randomIndex];

        // 선택된 이벤트의 설명을 화면에 표시
        eventDescription.text = selectedEvent.description;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            // 선택지 텍스트를 버튼에 설정
            choiceButtons[i].GetComponentInChildren<TMP_Text>().text = selectedEvent.choices[i];

            // 클로저 문제를 방지하기 위한 임시 변수
            int choice = i;
            // 선택지 버튼에 클릭 리스너 추가
            choiceButtons[i].onClick.AddListener(() => OnChoiceMade(choice));
        }

        // 이벤트 패널 활성화
        eventPanel.SetActive(true);

    }

    public void OnChoiceMade(int choiceIndex)
    {
        List<int> outcomesIndices = choiceOutcomeIndices[choiceIndex];

        foreach (int index in outcomesIndices)
        {
            EventOutcome outcome = selectedEvent.outcomes[index];

            // 확률을 이용해서 결과 결정
            float randomValue = Random.value;
            if (randomValue <= outcome.probability)
            {
                feedbackText.text = outcome.outcomeText;

                // 플레이어 상태에 결과 적용
                playerManager.MaritalScore += outcome.statusChange.maritalScore;
                playerManager.HealthScore += outcome.statusChange.healthScore;
                playerManager.ReputationScore += outcome.statusChange.reputationScore;
                playerManager.SocialScore += outcome.statusChange.socialScore;
                playerManager.WealthScore += outcome.statusChange.wealthScore;
                playerManager.ChildrenScore += outcome.statusChange.childrenScore;
                //... 기타 변경 사항 적용
            }
        }

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



