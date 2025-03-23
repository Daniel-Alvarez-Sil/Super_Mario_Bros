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


    // private void CerrarAyuda()
    // {
    //     vMenu.style.display = DisplayStyle.None;
    // }
}