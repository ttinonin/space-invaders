using UnityEngine;
using UnityEngine.UI;

public class PlayerPoints : MonoBehaviour
{
    public int currentPoints = 0;
    public Text pointsText;

    void Start()
    {
        UpdatePointsUI();
    }

    public void AddPoints(int points)
    {
        currentPoints += points;
        UpdatePointsUI();
    }

    void UpdatePointsUI()
    {
        if (pointsText != null)
        {
            pointsText.text = "Pontos: " + currentPoints.ToString();
        }
    }
}
