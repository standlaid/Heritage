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
    private void Start()
    {
        // �ʱ⿡�� �г��� ���ϴ�.
        eventPanel.SetActive(false);
        feedbackPanel.SetActive(false);
    }

    public void TriggerRandomEvent()
    {
        // ���� �̺�Ʈ�� �ҷ��ɴϴ� (�� �κ��� ���߿� ������ �������� �ٲ� �� �ֽ��ϴ�)
        string randomEvent = "���� ���� �߻��߽��ϴ�.";
        string[] choices = { "���� 1", "���� 2", "���� 3" };

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
        // ���⼭ ���ÿ� ���� ������ �����մϴ�.
        // ���� ���, ���ÿ� ���� ���� �� ������ �����ϰų� �� �̺�Ʈ�� Ʈ������ �� �ֽ��ϴ�.

        feedbackText.text = "����� ������ " + choiceIndex + "��° �������Դϴ�.";
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



