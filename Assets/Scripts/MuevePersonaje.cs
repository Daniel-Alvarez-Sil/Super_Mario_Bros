/*
    Daniel Alvarez Sil
    - Propósito:    Este script mueve un personaje 2D usando Rigidbody2D. Permite moverse horizontalmente y 
                    saltar solo si se presiona una tecla hacia arriba; si no, mantiene la velocidad vertical actual.
*/


using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{

    // Velocidades
    public float velocidadX;

    [SerializeField]  
    private float velocidadY;

    private Rigidbody2D rb;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        if (movVertical > 0) {
            rb.linearVelocity = new Vector2(movHorizontal*velocidadX, movVertical*velocidadY);
        } else {
            rb.linearVelocity = new Vector2(movHorizontal*velocidadX, rb.linearVelocityY);
        }
    }
}