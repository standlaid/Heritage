using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static PlayerManager;

[CreateAssetMenu(menuName = "EventLists/Event")]
public class EventData : ScriptableObject
{
    public int eventNumber;
    public string eventName;
    public string attribute;
    public string description;
    public string[] choices = new string[3];
    public EventOutcome[] outcomes = new EventOutcome[6];    
                 
}

[System.Serializable]
public class EventOutcome
{
    public string outcomeText;
    public float probability;
    public PlayerStatusChange statusChange;
}

[System.Serializable]
public class PlayerStatusChange
{
    public int maritalScore;
    public int childrenScore;
    public int wealthScore;
    public int socialScore;
    public int healthScore;
    public int reputationScore;

}