using UnityEngine;
using UnityEngine.SceneManagement; 

public class Enemy : MonoBehaviour
{
    public int pointsValue = 10;

    void OnDestroy()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null) {
            if (player.GetComponent<PlayerPoints>().currentPoints >= 300) {
                SceneManager.LoadScene("YouWin");
            }

            player.GetComponent<PlayerPoints>().AddPoints(pointsValue);
        }
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
