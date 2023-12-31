using TMPro;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    void Start()
    {
        UpdateUI();
    }

    public TMP_Text label;
    public Quest quest;
    public void UpdateUI()
    {
        if (quest.IsAccepted())
        {
            this.label.text = "0/1 Cop killed";
        }
        else
        {
            this.label.text = "";
        }

        if (quest.IsCompleted())
        {
            this.label.text = "Quest completed!";
        }
        
        if (quest.IsFinished())
        {
            this.label.text = "";
        }
    }
}