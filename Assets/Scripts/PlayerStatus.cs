using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    //이름, 나이, 신분, 결혼 유무, 자식 수, 건강, 재산, 평판

    // 캐릭터의 이름    
    public string characterName;

    // 캐릭터의 나이
    public int characterAge;

    // 캐릭터의 신분
    public SocialStatus socialStatus;

    // 결혼 유무 (true: 결혼, false: 미혼)
    public bool maritalStatus;

    // 캐릭터의 자식 수
    public int numberOfChildren;

    // 캐릭터의 건강 상태
    //public HealthCondition healthCondition;

    // 캐릭터의 재산
    public int wealthAmount;

    // 캐릭터의 평판 점수
    public int reputationScore;

    public enum SocialStatus
    {
        Slave,      // 노예나 노비
        Commoner,   // 보통 사람
        Noble,      // 고위 계층
        Royalty     // 왕 가족
    }

    // 건강 상태에 관련된 enum


    void Update()
    {

    }

    public void PassOnToChild(PlayerStatus childStatus)
    {
        // 상태를 자식에게 전달합니다.
        childStatus.characterName = this.characterName + " Jr."; // 예시로, 이름 뒤에 "Jr."을 붙여서 전달합니다.
        childStatus.characterAge = 0; // 자식의 나이를 0으로 설정
        childStatus.socialStatus = this.socialStatus;
        childStatus.maritalStatus = false; // 미혼으로 설정
        childStatus.numberOfChildren = 0; // 아이 수를 0으로 설정
        //childStatus.healthCondition = HealthCondition.Normal; // 건강 상태를 '정상'으로 설정
        childStatus.wealthAmount = Mathf.FloorToInt(this.wealthAmount * 0.5f); // 재산의 절반을 상속 (예시)
        childStatus.reputationScore = Mathf.FloorToInt(this.reputationScore * 0.8f); // 평판 점수의 80%를 상속 (예시)
    }
}


