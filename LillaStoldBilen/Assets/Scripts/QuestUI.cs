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
            this.label.text = $"{quest.GetCopKilled()}/1 Cop killed";
        }
        else
        {
            this.label.text = "";
        }
    }
}