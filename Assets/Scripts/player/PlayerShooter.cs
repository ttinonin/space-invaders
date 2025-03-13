using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // Arrasta o prefab aqui no Inspector
    public Transform firePoint; // Ponto de origem do tiro

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Dispara apenas quando a tecla for pressionada
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
    }
}
