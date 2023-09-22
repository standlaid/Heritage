using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //플레이어의 최종 상태
    public string characterName;                // 캐릭터의 이름        
    public int characterAge;                    // 캐릭터의 나이
    public bool maritalStatus;                  // 결혼 유무    
    public int numberOfChildren;                // 캐릭터의 자식 수    
    public int wealthAmount;                    // 캐릭터의 재산    
    public SocialStatus socialStatus;           // 캐릭터의 신분 상태 모음
    public HealthCondition healthCondition;     // 캐릭터의 건강 상태 모음 
    public Reputation reputation;               // 캐릭터의 평판 상태 모음

    //스크립터블 오브젝트로 제어 받는 플레이어의 상태 점수

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
                socialStatus = SocialStatus.노예;
            }
            else if (socialScore <= 50)
            {
                socialStatus = SocialStatus.평민;
            }
            else if (socialScore <= 75)
            {
                socialStatus = SocialStatus.귀족;
            }
            else
            {
                socialStatus = SocialStatus.왕족;
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
                healthCondition = HealthCondition.사망;
            }
            else if (healthScore <= 25)
            {
                healthCondition = HealthCondition.위독;
            }
            else if (healthScore <= 50)
            {
                healthCondition = HealthCondition.질병;
            }
            else
            {
                healthCondition = HealthCondition.양호;
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
                reputation = Reputation.악명높음;
            }
            else if (socialScore <= 20)
            {
                reputation = Reputation.신용불량;
            }
            else if (socialScore <= 40)
            {
                reputation = Reputation.중립적인;
            }
            else if (socialScore <= 60)
            {
                reputation = Reputation.존경받음;
            }
            else if (socialScore <= 80)
            {
                reputation = Reputation.명성높음;
            }
        }
    }

    private int maritalScore;                    // 결혼 점수       
    public int childrenScore;                   // 캐릭터의 자식 점수    
    public int wealthScore;                     // 캐릭터의 재산 점수   
    public int socialScore;                     // 캐릭터의 신분 점수
    public int healthScore;                     // 캐릭터의 건강 점수
    public int reputationScore;                 // 캐릭터의 평판 점수


    public TMP_Text nameText;                   // 캐릭터의 이름      텍스트 
    public TMP_Text ageText;                    // 캐릭터의 나이      텍스트 
    public TMP_Text maritalStatusText;          // 결혼 유무          텍스트 
    public TMP_Text numberOfChildrenText;       // 캐릭터의 자식 수   텍스트 
    public TMP_Text wealthText;                 // 캐릭터의 재산      텍스트 
    public TMP_Text socialStatusText;           // 캐릭터의 신분      텍스트 
    public TMP_Text healthConditionText;        // 캐릭터의 건강 상태 텍스트 
    public TMP_Text reputationText;             // 캐릭터의 평판 상태 텍스트 

    public enum SocialStatus
    {
        노예,
        평민,
        귀족,
        왕족
    }

    // 건강 상태에 관련된 enum
    public enum HealthCondition
    {
        사망,
        위독,
        질병,
        부상,
        양호,
    }
    public enum Reputation
    {
        악명높음,
        신용불량,
        중립적인,
        존경받음,
        명성높음
    }

    void Update()
    {
        // 각 UI 텍스트 업데이트
        nameText.text = "이름: " + characterName;
        ageText.text = "나이: " + characterAge.ToString();
        maritalStatusText.text = "결혼 유무: " + (maritalStatus ? "기혼" : "미혼");
        numberOfChildrenText.text = "자식 수: " + numberOfChildren.ToString();
        wealthText.text = "재산: " + wealthAmount.ToString() + "G";
        socialStatusText.text = "신분: " + socialStatus.ToString();
        healthConditionText.text = "건강: " + healthCondition.ToString();
        reputationText.text = "평판: " + reputation.ToString();
    }

    //public class PlayerStatusChange
    //{
    //    public int ageChange;
    //    public int wealthChange;
    //    public Reputation reputationChange;
    //}
    }