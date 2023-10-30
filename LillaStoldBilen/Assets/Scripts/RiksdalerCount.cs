using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class RiksdalerCount : MonoBehaviour
{
    public int count;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        count = PlayerPrefs.GetInt("amount");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "$" + count;
    }
}
