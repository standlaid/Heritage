using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //�÷��̾��� ���� ����
    public string characterName;                // ĳ������ �̸�        
    public int characterAge;                    // ĳ������ ����
    public bool maritalStatus;                  // ��ȥ ����    
    public int numberOfChildren;                // ĳ������ �ڽ� ��    
    public int wealthAmount;                    // ĳ������ ���    
    public SocialStatus socialStatus;           // ĳ������ �ź� ���� ����
    public HealthCondition healthCondition;     // ĳ������ �ǰ� ���� ���� 
    public Reputation reputation;               // ĳ������ ���� ���� ����

    //��ũ���ͺ� ������Ʈ�� ���� �޴� �÷��̾��� ���� ����

    public int MaritalScore
    {
    get { return maritalScore; }
    set {
            if (value>=3) 
            {
                return;
            }

            switch(value)
            {
                case 0:
                    
                    break;
                case 1:
                    maritalStatus = false;
                    break;
                case 2:
                    maritalStatus = true;
                    break;
            }
            maritalScore =  value;
        }
    }
    public int ChildrenScore
    {
        get { return childrenScore; }
        set
        {
            childrenScore = Mathf.Max(0, value);
        }
    }
    public int WealthScore
    {
        get { return wealthScore; }
        set
        {
            wealthScore = value;
        }
    }
    public int SocialScore
    {
        get { return socialScore; }
        set
        {
            socialScore = Mathf.Clamp(value, 0, 100);

            if (socialScore <= 25)
            {
                socialStatus = SocialStatus.�뿹;
            }
            else if (socialScore <= 50)
            {
                socialStatus = SocialStatus.���;
            }
            else if (socialScore <= 75)
            {
                socialStatus = SocialStatus.����;
            }
            else
            {
                socialStatus = SocialStatus.����;
            }
        }
    }
    public int HealthScore
    {
        get { return healthScore; }
        set
        {
            healthScore = Mathf.Clamp(value, 0, 100);

            if (healthScore <= 0)
            {
                healthCondition = HealthCondition.���;
            }
            else if (healthScore <= 25)
            {
                healthCondition = HealthCondition.����;
            }
            else if (healthScore <= 50)
            {
                healthCondition = HealthCondition.����;
            }
            else
            {
                healthCondition = HealthCondition.��ȣ;
            }
        }
    }
    public int ReputationScore
    {
        get { return reputationScore; }
        set
        {
            reputationScore = Mathf.Clamp(value, 0, 100);

            if (reputationScore <= 0)
            {
                reputation = Reputation.�Ǹ����;
            }
            else if (socialScore <= 20)
            {
                reputation = Reputation.�ſ�ҷ�;
            }
            else if (socialScore <= 40)
            {
                reputation = Reputation.�߸�����;
            }
            else if (socialScore <= 60)
            {
                reputation = Reputation.�������;
            }
            else if (socialScore <= 80)
            {
                reputation = Reputation.������;
            }
        }
    }

    private int maritalScore;                    // ��ȥ ����       
    public int childrenScore;                   // ĳ������ �ڽ� ����    
    public int wealthScore;                     // ĳ������ ��� ����   
    public int socialScore;                     // ĳ������ �ź� ����
    public int healthScore;                     // ĳ������ �ǰ� ����
    public int reputationScore;                 // ĳ������ ���� ����


    public TMP_Text nameText;                   // ĳ������ �̸�      �ؽ�Ʈ 
    public TMP_Text ageText;                    // ĳ������ ����      �ؽ�Ʈ 
    public TMP_Text maritalStatusText;          // ��ȥ ����          �ؽ�Ʈ 
    public TMP_Text numberOfChildrenText;       // ĳ������ �ڽ� ��   �ؽ�Ʈ 
    public TMP_Text wealthText;                 // ĳ������ ���      �ؽ�Ʈ 
    public TMP_Text socialStatusText;           // ĳ������ �ź�      �ؽ�Ʈ 
    public TMP_Text healthConditionText;        // ĳ������ �ǰ� ���� �ؽ�Ʈ 
    public TMP_Text reputationText;             // ĳ������ ���� ���� �ؽ�Ʈ 

    public enum SocialStatus
    {
        �뿹,
        ���,
        ����,
        ����
    }

    // �ǰ� ���¿� ���õ� enum
    public enum HealthCondition
    {
        ���,
        ����,
        ����,
        �λ�,
        ��ȣ,
    }
    public enum Reputation
    {
        �Ǹ����,
        �ſ�ҷ�,
        �߸�����,
        �������,
        ������
    }

    void Update()
    {
        // �� UI �ؽ�Ʈ ������Ʈ
        nameText.text = "�̸�: " + characterName;
        ageText.text = "����: " + characterAge.ToString();
        maritalStatusText.text = "��ȥ ����: " + (maritalStatus ? "��ȥ" : "��ȥ");
        numberOfChildrenText.text = "�ڽ� ��: " + numberOfChildren.ToString();
        wealthText.text = "���: " + wealthAmount.ToString() + "G";
        socialStatusText.text = "�ź�: " + socialStatus.ToString();
        healthConditionText.text = "�ǰ�: " + healthCondition.ToString();
        reputationText.text = "����: " + reputation.ToString();
    }

    //public class PlayerStatusChange
    //{
    //    public int ageChange;
    //    public int wealthChange;
    //    public Reputation reputationChange;
    //}
    }