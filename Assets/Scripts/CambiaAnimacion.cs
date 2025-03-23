/*
    Daniel Alvarez Sil
    - Propósito:    Este script en Unity actualiza la animación de un personaje 2D según su velocidad y si está en el suelo. 
                    También voltea el sprite horizontalmente dependiendo de la dirección del movimiento.
*/

using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float velocidad = rb.linearVelocity.x;
        animator.SetBool("enPiso", EstadoPersonaje.enPiso);

        // Cambiar la animación de caminar
        animator.SetFloat("velocidad", Mathf.Abs(velocidad));

        // Cambiar la dirección del personaje según la velocidad
        if (velocidad < 0)
        {
            spRenderer.flipX = true; // Voltea el sprite a la izquierda
        }
        else if (velocidad > 0)
        {
            spRenderer.flipX = false; // Voltea el sprite a la derecha
        }
    }
}