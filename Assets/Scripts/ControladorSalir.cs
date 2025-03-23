/*
    Daniel Alvarez Sil
    - Propósito:    Este script en Unity asigna una función al botón "boton-salir" de una interfaz UI Toolkit, 
                    y al hacer clic termina el juego. 
*/


using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ControladorSalir: MonoBehaviour
{
    private UIDocument menu;
    private Button botonSalir;
    private VisualElement vMenu;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Referencias a los botones
        botonSalir = root.Q<Button>("boton-salir");

        // Referencia al menú de ayuda
        vMenu = root.Q<VisualElement>("Menu");

        // Asignación de eventos de clic
        botonSalir.RegisterCallback<ClickEvent>(QuitGame);
    }


    private void QuitGame(ClickEvent evt)
    {
        Application.Quit();
        // Mensaje para no utilizar build and run
        Debug.Log("Cerrando juego..."); 
    }
}