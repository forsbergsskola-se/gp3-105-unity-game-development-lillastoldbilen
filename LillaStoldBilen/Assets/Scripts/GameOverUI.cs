using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{

    public TMP_Text label;
    public Player player;

    public bool deathAnimation; // Animation-Purpose
    
    public void UpdateUI(float newHealth)
    {
        if (newHealth <= 0)
        {
            this.label.text = "GAME OVER";
            deathAnimation = true;
            FindObjectOfType<PlayerController>().enabled = false;
            StartCoroutine(Co_PlayerDeath());
        }
    }

    IEnumerator Co_PlayerDeath()
    {
        int halfMoney = player.MoneyBag / 2;
        player.MoneyBag = halfMoney;
        yield return new WaitForSeconds(6);
        Destroy(player.gameObject);
        SceneManager.LoadScene("Main Game");
        deathAnimation = false;
        FindObjectOfType<PlayerController>().enabled = true;

    }
}