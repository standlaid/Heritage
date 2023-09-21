using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    public string characterName;    // 캐릭터의 이름        
    public bool maritalStatus;      // 결혼 유무 (true: 결혼, false: 미혼)

    
    public int characterAge;        // 캐릭터의 나이
    // 캐릭터의 자식 수
    public int numberOfChildren;
    // 캐릭터의 재산
    public int wealthAmount;

    // 캐릭터의 신분
    public SocialStatus socialStatus;
    // 캐릭터의 건강 상태
    public HealthCondition healthCondition;
    // 캐릭터의 평판 상태
    public Reputation reputation;


    public enum SocialStatus
    {
        Slave,      // 노예나 노비
        Commoner,   // 보통 사람
        Noble,      // 고위 계층
        Royalty     // 왕 가족
    }

    // 건강 상태에 관련된 enum
    public enum HealthCondition
    {
        Dead,       // 사망
        VeryPoor,   // 매우 악화된 상태
        Poor,       // 일반적인 병
        Injured,    // 부상
        Normal,     // 정상 상태
    }
    public enum Reputation
    {
        Notorious,   // 악명 높은
        Untrustworthy, // 믿을 수 없는
        Neutral,     // 중립적인
        Respected,   // 존경받는
        Renowned     // 명성이 있는
    }

    void Update()
    {

    }

    public class PlayerStatusChange
    {
        public int ageChange;
        public int wealthChange;
        public Reputation reputationChange;
    }
    }