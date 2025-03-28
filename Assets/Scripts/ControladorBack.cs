/*
    Daniel Alvarez Sil
    - Propósito:    Este script en Unity asigna una función al botón "boton-regresar" de una interfaz UI Toolkit, 
                    y al hacer clic carga la escena llamada "SampleScene", el cual es el MENU PRINCIPAL. 
*/


using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ControladorReturn : MonoBehaviour
{
    private UIDocument menu;
    private Button botonRegresar;
    private VisualElement vMenu;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Referencias a los botones
        botonRegresar = root.Q<Button>("boton-regresar");

        // Referencia al menú de ayuda
        vMenu = root.Q<VisualElement>("Menu");

        // Asignación de eventos de clic
        botonRegresar.RegisterCallback<ClickEvent>(evt => CargarEscena("SampleScene"));
    }


    private void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}