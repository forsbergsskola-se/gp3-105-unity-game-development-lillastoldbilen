using System;
using UnityEngine;
using UnityEngine.Android;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Player player;
    void Update()
    {
        if ()
        {
            quest.StartQuest();
        }
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