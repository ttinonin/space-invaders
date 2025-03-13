using UnityEngine;

public class ProjectPrefab : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destrói o inimigo
            Destroy(gameObject); // Destrói o tiro
        } else if (other.CompareTag("Barreira")) {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
