/*
    Daniel Alvarez Sil
    - Propósito:    Este script detecta si el personaje está tocando el suelo mediante colisiones 2D y 
                    actualiza una variable estática enPiso, usada por otros scripts para saber si el personaje puede, 
                    por ejemplo, saltar.
*/


using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    public static bool enPiso { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enPiso = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }
}