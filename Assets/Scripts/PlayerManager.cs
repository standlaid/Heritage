using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    public string characterName;    // ĳ������ �̸�        
    public bool maritalStatus;      // ��ȥ ���� (true: ��ȥ, false: ��ȥ)

    
    public int characterAge;        // ĳ������ ����
    // ĳ������ �ڽ� ��
    public int numberOfChildren;
    // ĳ������ ���
    public int wealthAmount;

    // ĳ������ �ź�
    public SocialStatus socialStatus;
    // ĳ������ �ǰ� ����
    public HealthCondition healthCondition;
    // ĳ������ ���� ����
    public Reputation reputation;


    public enum SocialStatus
    {
        Slave,      // �뿹�� ���
        Commoner,   // ���� ���
        Noble,      // ���� ����
        Royalty     // �� ����
    }

    // �ǰ� ���¿� ���õ� enum
    public enum HealthCondition
    {
        Dead,       // ���
        VeryPoor,   // �ſ� ��ȭ�� ����
        Poor,       // �Ϲ����� ��
        Injured,    // �λ�
        Normal,     // ���� ����
    }
    public enum Reputation
    {
        Notorious,   // �Ǹ� ����
        Untrustworthy, // ���� �� ����
        Neutral,     // �߸�����
        Respected,   // ����޴�
        Renowned     // ���� �ִ�
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