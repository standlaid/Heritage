using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    public PlayerManager playerManager; // PlayerManager ����

    public GameObject eventPanel;
    public TMP_Text eventDescription;
    public Button[] choiceButtons;
    public GameObject feedbackPanel;
    public TMP_Text feedbackText;

    public EventData[] allEvents;


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
        EventData selectedEvent = allEvents[randomIndex];

        // ���õ� �̺�Ʈ�� ������ ȭ�鿡 ǥ��
        eventDescription.text = selectedEvent.description;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            // ������ �ؽ�Ʈ�� ��ư�� ����
            choiceButtons[i].GetComponentInChildren<TMP_Text>().text = selectedEvent.choices[i];

            // Ŭ���� ������ �����ϱ� ���� �ӽ� ����
            int choice = i;
            // ������ ��ư�� Ŭ�� ������ �߰�
            choiceButtons[i].onClick.AddListener(() => OnChoiceMade(choice, selectedEvent.outcomes[choice]));
        }

        // �̺�Ʈ �г� Ȱ��ȭ
        eventPanel.SetActive(true);

    }

    public void OnChoiceMade(int choiceIndex, EventOutcome outcome)
    {
        // Ȯ���� �̿��ؼ� ��� ����
        float randomValue = Random.value;
        if (randomValue <= outcome.probability)
        {
            feedbackText.text = outcome.outcomeText;

            // �÷��̾� ���¿� ��� ����
            playerManager.maritalStatus = outcome.statusChange.maritalStatus;

            playerManager.healthCondition = outcome.statusChange.healthCondition;
            playerManager.reputation = outcome.statusChange.reputation;
            playerManager.socialStatus = outcome.statusChange.socialStatus;

            playerManager.wealthAmount += outcome.statusChange.wealthAmount;            
            playerManager.healthCondition += outcome.statusChange.numberOfChildren;
            //... ��Ÿ ���� ���� ����
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



