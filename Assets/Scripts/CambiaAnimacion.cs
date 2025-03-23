using UnityEngine;

/**
Modificar las variables del Animator que realiza las transiciones de las animaciones  
Autor: Roberto Mtz. Román
*/
public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
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