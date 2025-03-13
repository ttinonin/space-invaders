using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;

    public Text livesText;

    void Start()
    {
        currentLives = maxLives;
        UpdateLivesUI();
    }

    public void TakeDamage()
    {
        Debug.Log(currentLives);
        currentLives--;
        UpdateLivesUI();

        if (currentLives <= 0)
        {
            Die();
        }
    }

    void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "Vidas: " + currentLives.ToString();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }
}
