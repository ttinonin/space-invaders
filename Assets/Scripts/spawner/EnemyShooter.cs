using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public float shootInterval = 2f;

    void Start()
    {
        InvokeRepeating("Shoot", Random.Range(1f, 3f), shootInterval);
    }

    void Shoot()
    {
        Vector3 spawnPosition = transform.position + Vector3.down * 0.5f; // Cria o tiro um pouco abaixo
        Instantiate(enemyBulletPrefab, spawnPosition, Quaternion.identity);
    }

}
