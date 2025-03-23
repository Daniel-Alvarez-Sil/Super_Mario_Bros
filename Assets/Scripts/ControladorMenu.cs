using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ControladorMenu : MonoBehaviour
{
    private UIDocument menu;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;
    private Button botonSalir;
    private VisualElement vMenu;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Referencias a los botones
        botonJugar = root.Q<Button>("boton-juego");
        botonAyuda = root.Q<Button>("boton-ayuda");
        botonCreditos = root.Q<Button>("boton-creditos");
        botonSalir = root.Q<Button>("boton-salir");

        // Referencia al menú de ayuda
        vMenu = root.Q<VisualElement>("Menu");

        // Asignación de eventos de clic
        botonJugar.RegisterCallback<ClickEvent>(evt => CargarEscena("Game"));
        botonAyuda.RegisterCallback<ClickEvent>(evt => CargarEscena("help"));
        botonCreditos.RegisterCallback<ClickEvent>(evt => CargarEscena("credits"));
        // botonSalir.RegisterCallback<ClickEvent>(evt => CerrarAyuda());
    }

    private void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    private void MostrarAyuda()
    {
        vMenu.style.display = DisplayStyle.Flex;
        vMenu.Q<Label>("ayuda").text = "¡Hola! Bienvenido al menú de ayuda del juego de Mario Bros.\n\n" +
            "Este es un juego creado en Unity para practicar el uso de funciones básicas, interfaces gráficas y elementos interactivos.\n\n" +
            "El objetivo principal es experimentar con el motor de Unity y aprender a crear juegos sencillos, utilizando conceptos fundamentales de diseño y programación.\n\n" +
            "¡Explora los niveles, recolecta monedas y enfréntate a los clásicos desafíos de Mario!\n\n" +
            "¡Diviértete y disfruta de la experiencia!";
    }


    // private void CerrarAyuda()
    // {
    //     vMenu.style.display = DisplayStyle.None;
    // }
}