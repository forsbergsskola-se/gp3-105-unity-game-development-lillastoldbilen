using System;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        
    }

    public void StartQuest()
    {
        Debug.Log("Start Quest", this);
    }
}

/*
public Quest quest;
public GameObject player = GameObject.Find("Player");

public void StartQuest()
{
    Debug.Log("Start Quest", this);
}
*/