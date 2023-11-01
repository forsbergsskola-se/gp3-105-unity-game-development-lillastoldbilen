using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
        void Start()
        {
                UpdateUI();
        }

        public TMP_Text label;
        public PlayerHealth playerHealth;
        public Player player;
        

        public void UpdateUI()
        {
                if (playerHealth.health <= 0)
                {
                        this.label.text = "GAME OVER";
                }
        }

        public void PlayerDeath()
        {
                if (playerHealth.health <= 0)
                {
                        StartCoroutine(OnDeath());
                }
        }
        
        IEnumerator OnDeath()
        {
                Destroy(player.gameObject);
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene("Main Game");
        }
}