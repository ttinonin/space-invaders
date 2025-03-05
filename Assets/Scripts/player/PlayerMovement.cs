using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode moveLeft= KeyCode.LeftArrow;

    private Rigidbody2D rb2d;
    private int state = 0;
    private float x;
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();  
    }

    void Move(){
        var vel = rb2d.linearVelocity;                // Acessa a velocidade da raquete
        if (Input.GetKey(moveRight)) {             // Velocidade da Raquete para ir para cima
            vel.x = speed;
        }
        else if (Input.GetKey(moveLeft)) {      // Velocidade da Raquete para ir para cima
            vel.x = -speed;                    
        }
        else {
            vel.x = 0;                          // Velociade para manter a raquete parada
        }
        rb2d.linearVelocity = vel;                    // Atualizada a velocidade da raquete
    }

    void Update() {
        Move();
    }
}
