using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    //�̸�, ����, �ź�, ��ȥ ����, �ڽ� ��, �ǰ�, ���, ����

    // ĳ������ �̸�    
    public string characterName;

    // ĳ������ ����
    public int characterAge;

    // ĳ������ �ź�
    public SocialStatus socialStatus;

    // ��ȥ ���� (true: ��ȥ, false: ��ȥ)
    public bool maritalStatus;

    // ĳ������ �ڽ� ��
    public int numberOfChildren;

    // ĳ������ �ǰ� ����
    //public HealthCondition healthCondition;

    // ĳ������ ���
    public int wealthAmount;

    // ĳ������ ���� ����
    public int reputationScore;

    public enum SocialStatus
    {
        Slave,      // �뿹�� ���
        Commoner,   // ���� ���
        Noble,      // ���� ����
        Royalty     // �� ����
    }

    // �ǰ� ���¿� ���õ� enum


    void Update()
    {

    }

    public void PassOnToChild(PlayerStatus childStatus)
    {
        // ���¸� �ڽĿ��� �����մϴ�.
        childStatus.characterName = this.characterName + " Jr."; // ���÷�, �̸� �ڿ� "Jr."�� �ٿ��� �����մϴ�.
        childStatus.characterAge = 0; // �ڽ��� ���̸� 0���� ����
        childStatus.socialStatus = this.socialStatus;
        childStatus.maritalStatus = false; // ��ȥ���� ����
        childStatus.numberOfChildren = 0; // ���� ���� 0���� ����
        //childStatus.healthCondition = HealthCondition.Normal; // �ǰ� ���¸� '����'���� ����
        childStatus.wealthAmount = Mathf.FloorToInt(this.wealthAmount * 0.5f); // ����� ������ ��� (����)
        childStatus.reputationScore = Mathf.FloorToInt(this.reputationScore * 0.8f); // ���� ������ 80%�� ��� (����)
    }
}


