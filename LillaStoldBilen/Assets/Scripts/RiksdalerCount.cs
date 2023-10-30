using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class RiksdalerCount : MonoBehaviour
{
    public int count;
    public Player player;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        player.CashIn(count);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.MoneyBag + "SEK";
    }
}
