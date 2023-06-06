using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class notseeobj : MonoBehaviour
{
    // Ustaw przezroczysto�� obiektu
    public bool isVisible = true;

    private Renderer renderer;

    private void Start()
    {
        // Pobierz komponent Renderer obiektu
        renderer = GetComponent<Renderer>();

        // Ustaw widoczno�� na pocz�tku
        SetVisibility(isVisible);
    }

    public void SetVisibility(bool visible)
    {
        isVisible = visible;

        // W��cz lub wy��cz renderowanie obiektu
        renderer.enabled = isVisible;
    }
}


//mozna dodac zeby strzelanie nie zostawialo sladow tutaj