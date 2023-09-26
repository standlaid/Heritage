using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    public PlayerManager playerManager; // PlayerManager ����

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
        // �ʱ⿡�� �г��� ���ϴ�.
        eventPanel.SetActive(false);
        feedbackPanel.SetActive(false);
    }

    public void TriggerRandomEvent()
    {
        
        // ������ �̺�Ʈ�� ����
        int randomIndex = Random.Range(0, allEvents.Length);
        selectedEvent = allEvents[randomIndex];

        // ���õ� �̺�Ʈ�� ������ ȭ�鿡 ǥ��
        eventDescription.text = selectedEvent.description;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            // ���� ������ ����
            choiceButtons[i].onClick.RemoveAllListeners();

            // ������ �ؽ�Ʈ�� ��ư�� ����
            choiceButtons[i].GetComponentInChildren<TMP_Text>().text = selectedEvent.choices[i];

            // Ŭ���� ������ �����ϱ� ���� �ӽ� ����
            int choice = i;
            // ������ ��ư�� Ŭ�� ������ �߰�
            choiceButtons[i].onClick.AddListener(() => OnChoiceMade(choice));
        }

        // �̺�Ʈ �г� Ȱ��ȭ
        eventPanel.SetActive(true);

    }

    public void OnChoiceMade(int choiceIndex)
    {
        List<int> outcomesIndices = choiceOutcomeIndices[choiceIndex];

        int randomValue = Random.Range(0, 2);
        //Debug.Log(randomValue);
        foreach (int index in outcomesIndices)
        {
            EventOutcome outcome = selectedEvent.outcomes[index];

            // Ȯ���� �̿��ؼ� ��� ����
            if (randomValue == outcome.probability)
            {
                //Debug.Log(outcome.probability + "," + index);
                feedbackText.text = outcome.outcomeText;

                // �÷��̾� ���¿� ��� ����
                playerManager.MaritalScore = outcome.statusChange.maritalScore;
                playerManager.HealthScore += outcome.statusChange.healthScore;
                playerManager.ReputationScore += outcome.statusChange.reputationScore;
                playerManager.SocialScore += outcome.statusChange.socialScore;
                playerManager.WealthScore += outcome.statusChange.wealthScore;
                playerManager.ChildrenScore += outcome.statusChange.childrenScore;
                //... ��Ÿ ���� ���� ����
                Debug.Log("��ȥ: " + outcome.statusChange.maritalScore +
                      "�ڳ�: " + outcome.statusChange.childrenScore +
                      "���: " + outcome.statusChange.wealthScore +
                      "�ź�: " + outcome.statusChange.socialScore +
                      "�ǰ�: " + outcome.statusChange.healthScore +
                      "����: " + outcome.statusChange.reputationScore);
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



