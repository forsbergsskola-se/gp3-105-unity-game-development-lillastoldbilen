using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{

    public TMP_Text label;
    public Player player;

    public void UpdateUI(float newHealth)
    {
        if (newHealth <= 0)
        {
            this.label.text = "GAME OVER";
            StartCoroutine(Co_PlayerDeath());
        }
    }

    IEnumerator Co_PlayerDeath()
    {
        Destroy(player.gameObject);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Main Game");
    }
}