/*
    Daniel Alvarez Sil
    - Propósito:    Este script mueve un personaje 2D usando Rigidbody2D. Permite moverse horizontalmente y 
                    saltar solo si se presiona una tecla hacia arriba; si no, mantiene la velocidad vertical actual.
*/


using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    public float velocidadX;
    [SerializeField]
    private float velocidadY;

    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        // Horizontal movement
        Vector2 newVelocity = new Vector2(movHorizontal * velocidadX, rb.linearVelocity.y);

        // Jump only if grounded and pressing up
        if (movVertical > 0 && isGrounded)
        {
            newVelocity.y = velocidadY;
            isGrounded = false; // Prevent further jumps until grounded again
        }

        rb.linearVelocity = newVelocity;
    }

    // Detect when character touches the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts.Length > 0)
        {
            // Check that we are landing from above
            ContactPoint2D contact = collision.contacts[0];
            if (contact.normal.y > 0.5f)
            {
                isGrounded = true;
            }
        }
    }

    // Optional: Handle leaving the ground (like jumping off a platform)
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
